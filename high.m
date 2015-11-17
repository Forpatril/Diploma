function [H, T] = high(J)
    S = cputime;
    pq = paddedsize(size(J));
    D0 = 0.15*pq(1);
    
    [U, V] = dftuv(pq(1), pq(2));
    D = sqrt(U.^2 + V.^2);
    h = 1 - exp (-(D.^2)./(2*(D0^2)));
    
    %h = hpfilter('gaussian', pq(1), pq(2), d0);
    H = dftfilt(J, h);
    T = cputime - S;
end