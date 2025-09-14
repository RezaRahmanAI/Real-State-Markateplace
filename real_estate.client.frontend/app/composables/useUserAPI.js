export function useUserAPI(url, options) {
  const { $userapi } = useNuxtApp();
    return useFetch(url, {
      ...options,
      $fetch: $userapi
    })
  }