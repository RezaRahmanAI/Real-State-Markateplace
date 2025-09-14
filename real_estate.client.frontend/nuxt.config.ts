// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  compatibilityDate: "2025-03-01",

  future: {
    compatibilityVersion: 4,
  },

  experimental: {
    scanPageMeta: "after-resolve",
    sharedPrerenderData: false,
    compileTemplate: true,
    resetAsyncDataToUndefined: true,
    templateUtils: true,
    relativeWatchPaths: true,
    normalizeComponentNames: false,
    spaLoadingTemplateLocation: "within",
    defaults: {
      useAsyncData: {
        deep: true,
      },
    },
  },

  unhead: {
    renderSSRHeadOptions: {
      omitLineBreaks: false,
    },
  },

  devtools: { enabled: true },
  modules: [
    "@nuxtjs/tailwindcss",
    "@nuxt/image",
    "@nuxt/icon",
    "@nuxtjs/google-fonts",
    "@pinia/nuxt",
    "pinia-plugin-persistedstate/nuxt",
  ],

  runtimeConfig: {
    public: {
      baseURL: process.env.BASE_URL || "https://demo1.triconproperty.com",
      //baseURL: process.env.BASE_URL || "https://localhost:7208",
    },
  },


  nitro: {
    preset: "static",
  },
  devServer: {
    port: 5487,
  },
  ssr: false,
});
