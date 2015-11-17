function b = medfilt3(varargin)

[a, mn, padopt] = parse_inputs(varargin{:});

domain = ones(mn);
if (rem(prod(mn), 2) == 1)
    order = (prod(mn)+1)/2;
    b = ordfilt2(a, order, domain, padopt);
else
    order1 = prod(mn)/2;
    order2 = order1+1;
    b = ordfilt2(a, order1, domain, padopt);
    b2 = ordfilt2(a, order2, domain, padopt);
	if islogical(b)
		b = b | b2;
	else
		b =	imlincomb(0.5, b, 0.5, b2);
	end
end

function [a, mn, padopt] = parse_inputs(varargin)

a = varargin{1};

charLocation = [];
for k = 2:nargin
    if (ischar(varargin{k}))
        charLocation = [charLocation k];
    end
end

if (length(charLocation) > 1)
    % More than one string in input list
    eid = 'Images:medfilt2:tooManyStringInputs';
    error(eid,'%s','Too many input string arguments.');
elseif isempty(charLocation)
    % No string specified
    padopt = 'zeros';
else
    options = {'indexed', 'zeros', 'symmetric'};

    padopt = checkstrs(varargin{charLocation}, options, mfilename, ...
                       'PADOPT', charLocation);
    
    varargin(charLocation) = [];
end

if (strcmp(padopt, 'indexed'))
    if (isa(a,'double'))
        padopt = 'ones';
    else
        padopt = 'zeros';
    end
end

if length(varargin) == 1,
  mn = [3 3];% default
elseif length(varargin) >= 2,
  mn = varargin{2}(:).';
  if size(mn,2)~=2,
    msg = 'MEDFILT2(A,[M N]): Second argument must consist of two integers.';
    eid = 'Images:medfilt2:secondArgMustConsistOfTwoInts';
    error(eid, msg);
  elseif length(varargin) > 2,
    msg = ['MEDFILT2(A,[M N],[Mb Nb],...) is an obsolete syntax. [Mb Nb]' ...
             ' argument is ignored.'];
    wid = 'Images:medfilt2:obsoleteSyntax';
    warning(wid, msg);
  end
end

% The grandfathered [Mb Nb] argument, if present, is ignored.