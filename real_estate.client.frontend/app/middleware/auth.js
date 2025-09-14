export default defineNuxtRouteMiddleware((to, from)=>{
  const tokenStore = useTokenStore();

  if(!tokenStore.getLoggedinStatus){
      return navigateTo('/admin/login');
  }

  if (to.path === '/admin/login' && tokenStore.getLoggedinStatus) {
    // If already logged in, redirect from login to dashboard or home
    return navigateTo('/admin/dashboard');
  }

});