<template>
    <div>
      <!-- <Websiteheader/> -->
      <slot />
    </div>
  </template>
  
  <script setup>
  //https://nuxt.com/docs/api/composables/use-head


  // useHead({
  //   title: "kamal estate",
  //   htmlAttrs: {

  //   },
  //   bodyAttrs: {
      
  //   },
  // });


  import { useRoute } from 'vue-router';

  const route = useRoute();

  useHead({
    title: route.name ? `${route.name} - Kamal Estate` : 'Kamal Estate'
  });
  </script>
  
  <style>
  
  </style>