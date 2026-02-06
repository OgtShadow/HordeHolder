FROM node:20-alpine AS build
WORKDIR /app
COPY package*.json ./
RUN npm ci --silent
COPY . .
RUN npx ng build

CMD ["npx","ng","serve", "--port", "4200", "--host", "0.0.0.0"]