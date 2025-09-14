import { useAuthStore } from "#imports";

export const useTokenStore = defineStore('tokenStore', {
    state: () => ({
      token: null,
      loggedin: false
    }),
    persist: true,
    getters: {
        getToken: (state) => state.token,
        getLoggedinStatus: (state) => state.loggedin
    },
    actions: {
      setToken(token){
        this.token = token;
        this.loggedin = true;
      },
      removeToken(){
        const auth = useAuthStore();
        auth.$reset();
        this.$reset();
        return navigateTo("/admin/login");
      },

    }
  })