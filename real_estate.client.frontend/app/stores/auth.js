


export const useAuthStore = defineStore("authStore", {
  
  state: () => ({
    //id: "",
    email: "",
    id: "",
  }),
  actions: {
    async login(form) {
      const token = useTokenStore();

      console.log(form);

      const runtimeConfig = useRuntimeConfig();
      const baseUrl = runtimeConfig.public.baseURL
      console.log(baseUrl);
      
      try {
        const res = await $fetch(
          baseUrl + "/api/authentication/login",
          {
            method: "POST",
            headers: {
              "Content-Type": "application/json",
              Accept: "application/json",
            },
            body: { ...form },
          }
        );
        // this.id = data.id;
        console.log(res);
        this.email = res.email;
        this.id = res.id;

        token.setToken(res.token);
        return navigateTo("/admin/dashboard");
      } catch (error) {}
      
    },
    async logout() {
      try {
        
        const res = await useUserAPI("/modules", {
          method: "POST",
          headers: {
            Accept: "application/json",
            Authorization: `Bearer ${token.getToken}`,
          },
        });
        console.log(res);
        token.removeToken();
      } catch (error) {}
    },
  },
});
