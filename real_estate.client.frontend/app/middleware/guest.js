export default defineNuxtRouteMiddleware((to, from)=>{
    const tokenStore = useTokenStore();
    if(tokenStore.getLoggedinStatus){
        return navigateTo('/admin/dashboard');
    }
});