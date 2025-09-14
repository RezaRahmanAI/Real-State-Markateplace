export default defineNuxtPlugin((nuxtApp) => {
    const tokenStore = useTokenStore();
    const runtimeConfig = useRuntimeConfig()

    const adminapi = $fetch.create({
      baseURL: runtimeConfig.public.baseURL,
      onRequest({ request, options, error }) {
        if (tokenStore.getToken() != null) {
          options.headers.set('Authorization', `Bearer ${tokenStore.getToken()}`);
          options.headers.set("Accept","application/json");
        }
      },
      async onResponseError({ response }) {
        if (response.status === 401) {
          await nuxtApp.runWithContext(() => navigateTo('/admin/login'))
        }
      }
    })
  
    // Expose to useNuxtApp().$api
    return {
      provide: {
        adminapi
      }
    }
  })
  