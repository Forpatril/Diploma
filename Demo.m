img1 = double(imread('einstein.jpg'))/255;
[m, n] = size(img1);
u = imnoise2('uniform',m,n, 0, 0.055);
g = imnoise2('gaussian',m,n, 0, 0.055);
s = imnoise2('salt & pepper',m,n, 0.04, 0.04);
l = imnoise2('lognormal',m,n, 0.6, 0.25);
r = imnoise2('rayleigh',m,n, 0, 0.055);
ex = imnoise2('exponential',m,n, 15.6, 0.055);
er = imnoise2('erlang',m,n, 15.6, 3);

figure(1); clf;

subplot(2,4,1); imagesc(img1);
axis image; colormap gray;
title('Input');
subplot(2,4,2); imagesc(img1+u);
axis image; colormap gray;
title('Uniform');
subplot(2,4,3); imagesc(img1+g);
axis image; colormap gray;
title('Gaussian');

 c = s == 0;
 R = img1;
 R(c) = 0;
 c = r == 1;
 R(c) = 1;

subplot(2,4,4); imagesc(R);
axis image; colormap gray;
title('S&P');
subplot(2,4,5); imagesc(img1+l);
axis image; colormap gray;
title('Lognormal');
subplot(2,4,6); imagesc(img1+r);
axis image; colormap gray;
title('Rayleigh');
subplot(2,4,7); imagesc(img1+ex);
axis image; colormap gray;
title('Exponential');
subplot(2,4,8); imagesc(img1+er);
axis image; colormap gray;
title('Erlang');