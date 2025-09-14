export default defineNuxtPlugin((nuxtApp) => {
    const runtimeConfig = useRuntimeConfig();
  
    const userapi = $fetch.create({
      baseURL:  runtimeConfig.public.baseURL,
      onRequest({ request, options, error }) {
        options.headers.set("Accept","application/json");
      },
      async onResponseError({ response }) {
        
      }
    })
  
    // Expose to useNuxtApp().$api
    return {
      provide: {
        userapi
      }
    }
  })
  