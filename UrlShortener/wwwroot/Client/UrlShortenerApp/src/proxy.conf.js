const PROXY_CONFIG = [
    {
      context: ["/api"],
      target: "https://localhost:7087",
      secure: false,
      changeOrigin: true, // Додається для того, щоб проксі міг змінити оригінальний хост на цільовий
      pathRewrite: {
        "^/api": ""
      }
    }
  ]
  
  module.exports = PROXY_CONFIG;
  