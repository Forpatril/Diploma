function [f, t] = filter(image, type, param)
    switch type
        case 'bilateral'
            if nargin == 2
                w = 5;
                sigma = [3 0.1];
            else
                w = param(1);
                sigma = [param(2) param(3)];
            end
            [f, t] = bilateral(image, w, sigma);
        case 'high'
            [f, t] = high(image);
        case 'low'
            [f, t] = low(image);
        otherwise
            if nargin == 3
                m = param(1);
                n = param(2);
                p = param(3);
            end
            [f, t] = spfilt(image, type, m, n, p);
    end
end