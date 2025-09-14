
<template>
  <Websiteheader/>
  <Home />
  <Footer />
</template>

<script setup>
import Home from '~/components/Home.vue';
import Websiteheader from '~/components/Websiteheader.vue';
import Footer from '~/components/Footer.vue';

definePageMeta({
    Layout:false
});



</script>

<style scoped>

</style>
