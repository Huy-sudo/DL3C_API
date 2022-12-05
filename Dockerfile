FROM node:16 as build
WORKDIR /app
COPY package.json .
RUN npm i --legacy-peer-deps
RUN npm run build

FROM node:16-alpine
WORKDIR /app
COPY --from=build /app/node_modules ./node_modules
COPY --from=build /app/build ./build
RUN npm i -g serve
EXPOSE 3000
RUN ["serve", "-h", "build"]