export const useAdminAPI = (url, options) => {
  const { $adminapi } = useNuxtApp();
    return useFetch(url, {
      ...options,
      $fetch: $adminapi
    })
  }