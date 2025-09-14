<template>
  <Header />
  <Sidebar />

  <div class="p-4 sm:ml-64">
    <div class="p-4 mt-14">
      <slot />
    </div>
  </div>
</template>

<script setup>
//https://nuxt.com/docs/api/composables/use-head
useHead({
  title: "Login",
  htmlAttrs: {},
  bodyAttrs: {},
});
</script>

<style></style>
