<template>
  <div>
    <div class="headering py-36 sm:py-48 md:py-64 lg:py-72 xl:py-[200px]"></div>
    <div class="page_title absolute top-1/4 sm:top-1/3 md:top-2/4 lg:top-2/3 xl:top-3/4 2xl:top-[40%] left-0">
      <h1 class="text-2xl sm:text-3xl md:text-4xl text-slate-100 p-5">/ Gallery</h1>
    </div>

    <div class="project_gallary py-14 px-2">
      <div class="container mx-auto">
        <div>
          <div class="containerw">
            <div
              v-for="(image, index) in state.gallery"
              :key="index"
              class="item"
            >
              <a
                :href="
                  baseUrl + '/api/attachment/get/' +
                  image.contentName +
                  ''
                "
                data-fancybox="gallery"
              >
                <span v-if="image.contentType == 'Image'">
                  <img
                    class="w-full h-full"
                    :src="
                      baseUrl + '/api/attachment/get/'  +
                      image.contentName +
                      ''
                    "
                    alt=""
                  />
                </span>
                <span v-else-if="image.contentType == 'Video'">
                  <video class="w-full h-full" controls>
                    <source
                      :src="
                        baseUrl + '/api/attachment/get/' +
                        image.contentName +
                        ''
                      "
                      type="video/mp4"
                    />
                  </video>
                </span>
              </a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { onMounted } from "vue";

const runtimeConfig = useRuntimeConfig();
const baseUrl = runtimeConfig.public.baseURL
console.log(baseUrl);

const state = reactive({
  gallery: [],
});



var getGallery = async () => {
  const { data } = await useUserAPI("/api/website/getgallery", {
    method: "GET",
  });
  state.gallery = data.value;
};

onMounted(async () => {
  const { Fancybox } = await import("@fancyapps/ui");
  await import("@fancyapps/ui/dist/fancybox/fancybox.css");

  Fancybox.bind("[data-fancybox]", {});

  nextTick(async () => {
  getGallery();
});

});
</script>

<style scoped>
.headering {
  background: url(/assets/images/banner/banner-3.png) no-repeat center center;
  background-size: cover;
}
.containerw {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(350px, 1fr));
  justify-items: center;
  grid-gap: 0;
}
.item {
  width: 100%;
  overflow: hidden;
  background: #000;
}
.item a img {
  opacity: 0.6;
  width: 100%;
  height: 100%;
  transform: scale(1.15);
  transition: transform 0.5s, opacity 0.5s;
}
.item a img:hover {
  opacity: 1;
  transform: scale(1.03);
}
p {
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 400 !important;
  font-style: normal !important;
}
a {
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 600 !important;
  font-style: normal !important;
}
h1 {
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 700 !important;
  font-style: normal !important;
}
</style>
