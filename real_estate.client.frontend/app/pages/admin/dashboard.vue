<template>
  <div>
    <h1>Dashboard</h1>
    <h2></h2>
  </div>
</template>

<script setup>



definePageMeta({
  layout: "admin",
  middleware: ["auth"],
});

onMounted(() => {
  const tokenStore = useTokenStore();
  const token = tokenStore.getToken;
  console.log(token);
  console.log(tokenStore.getLoggedinStatus);

});

</script>

<style>

</style>