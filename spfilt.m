function [f, t] = spfilt(g, type, m, n, parameter)
if nargin == 2
    m = 3; n = 3; Q = 1.5; d = 2;
elseif nargin == 5
    Q = parameter; d = parameter;
elseif nargin == 4
    Q = 1.5; d = 2;
else
    error('Wrong number of inputs');
end
s = cputime;
switch type
    case 'amean'
        w = fspecial('average', [m n]);
        f = imfilter(g, w, 'replicate');
    case 'gmean'
        f = gmean(g, m, n);
    case 'hmean'
        f = harmean(g, m, n);
    case 'chmean'
        f = charmean(g, m, n, Q);
    case 'median'
        f = medfilt2(g, [m n], 'symmetric');
    case 'max'
        f = ordfilt2(g, m*n, ones(m, n), 'symmetric');
    case 'min'
        f = ordfilt2(g, 1, ones(m, n), 'symmetric');
    case 'midpoint'
        f1 = ordfilt2(g, 1, ones(m, n), 'symmetric');
        f2 = ordfilt2(g, m*n, ones(m, n), 'symmetric');
        f = imlincomb(0.5, f1, 0.5, f2);
    case 'atrimmed'
        if (d < 0) || (d/2 ~= round(d/2))
            error('d must be a nonnegative, even integer');
        end
        f = alphatrim(g, m, n, d);
    otherwise
        error('Unknown filter type')
end
t = cputime - s;
%---%
function f = gmean(g, m, n)
inclass = class(g);
g = im2double(g);
warning off;
f = exp(imfilter(log(g), ones(m, n), 'replicate')).^(1 / m / n);
warning on;
f = changeclass(inclass, f);
%---%
function f = harmean(g, m, n)
inclass = class(g);
g = im2double(g);
f = m * n ./ imfilter(1./(g + eps), ones(m, n), 'replicate');
f = changeclass(inclass, f);
%---%
function f = charmean(g, m, n, q)
inclass = class(g);
g = im2double(g);
f = imfilter(g.^(q+1), ones(m, n), 'replicate');
f = f ./ (imfilter(g.^q, ones(m, n), 'replicate'));
f = changeclass(inclass, f);
%---%
function f = alphatrim(g, m, n, d)
inclass = class(g);
g = im2double(g);
f = imfilter(g, ones(m, n), 'symmetric');
for k = 1:d/2
    f = imsubtract(f, ordfilt2(g, k, ones(m, n), 'symmetric'));
end
for k = (m*n - (d/2) + 1):m*n
    f = imsubtract(f, ordfilt2(g, k, ones(m, n), 'symmetric'));
end
f = f / (m*n - d);
f = changeclass(inclass, f);