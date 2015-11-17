function R = imnoise2(type, M, N, a, b)
    if nargin == 1
        a = 0; b = 1;
        M = 1; N = 1;
    elseif nargin == 3
        a = 0; b = 1;
    end
    switch lower(type)
        case 'uniform' %равномерный
            R = a + (b - a)*rand(M, N);
        case 'gaussian' %гауссов
            R = a + b*randn(M, N);
        case 'salt & pepper' %соль-перец
            if nargin <= 3
                a = 0.05; b = 0.05;
            end
            if (a + b) > 1
                error('The sum Pa + Pb must not esceed 1.')
            end
            R(1:M, 1:N) = 0.5;
            X = rand(M, N);
            c = X <= a;
            R(c) = 0;
            u = a + b;
            c = X > a & X <=u;
            R(c) = 1;
        case 'lognormal' %логарифмически нормальный
            if nargin <= 3
                a = 1; b = 0.25;
            end
            R = a*exp(b*randn(M,N));
        case 'rayleigh' %релеевский
            R = a + (-b*log(1 - rand(M, N))).^0.5;
        case 'exponential' %экспоненциальный
            if nargin <= 3
                a = 1;
            end
            if (a <= 0)
                error('Parameter a must be positive for exponential type')
            end
            k = -1/a;
            R = k*log(1 - rand(M, N));
        case 'erlang' %эрланга
            if nargin <= 3
                a = 2; b = 5;
            end
            if (b ~= round(b) || b <= 0)
                error('Param b must be a positive integer for Erlang')
            end
            k = -1/a;
            R = zeros(M, N);
            for j = 1:b
                R = R + k*log(1 - rand(M, N));
            end
        otherwise
            error('unknown distribution type.')
    end
end