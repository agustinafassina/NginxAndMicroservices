FROM nginx:stable

RUN rm /etc/nginx/conf.d/default.conf

COPY nginx.conf /etc/nginx/nginx.conf
COPY services.local.conf /etc/nginx/conf.d/services.local.conf
COPY two.local.conf /etc/nginx/conf.d/two.local.conf
COPY three.local.conf /etc/nginx/conf.d/three.local.conf
COPY four.local.conf /etc/nginx/conf.d/four.local.conf


CMD ["nginx"]
