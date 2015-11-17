function [L, T]=low(J)
    S = cputime;
    PQ = paddedsize(size(J));
    [U, V] = dftuv(PQ(1), PQ(2));
    D0 = 0.15*PQ(2);
    %F = fft2(J, PQ(1), PQ(2));
    H = exp(-(U.^2 + V.^2)/(2*(D0^2)));
    L = dftfilt(J, H);
    T = cputime - S; 
end
