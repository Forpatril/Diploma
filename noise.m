function R = noise(type, A, a, b, print)
    inclass = class(A);
    sz = size(A);
    if strcmp(type, 'salt & pepper')
        r = imnoise2(type, sz(1), sz(2), a, b);
        c = r == 0;
        R = A;
        R(c) = 0;
        c = r == 1;
        R(c) = 1;
    else 
        R = A + imnoise2(type, sz(1), sz(2), a, b);
        if strcmp(type, 'gaussian')
            c = R > 1;
            R(c) = 1;
        else
            m = max(max(R));
            R = R / m;
        end
    end
    R = changeclass(inclass, R);
    
    if print
        figure; clf;
        imagesc(R);
        axis image; colormap gray;
        title(type);
    end
end