<template>
  <div>
    <div class="headering py-36 sm:py-48 md:py-64 lg:py-72 xl:py-[200px]"></div>
    <div class="page_title absolute top-1/4 sm:top-1/3 md:top-2/4 lg:top-2/3 xl:top-3/4 2xl:top-[40%] left-0">
      <h1 class="text-2xl sm:text-3xl md:text-4xl text-slate-100 p-5">/ Blogs & Events</h1>
    </div>
    <div class="offer_projects py-14 bg-slate-50 px-4 sm:px-2 md:px-6 lg:px-10">
      <div class="lg:container mx-auto">
        <div class="grid grid-cols-1 sm:grid-cols-2 xl:grid-cols-3 gap-8 sm:gap-3 md:gap-8">
          <div
            v-for="(item, index) in state.list"
            :key="index"
            class="blog_card_box border rounded-3xl cursor-pointer hover:border-blue-500 hover:-translate-y-2 duration-500 ease-in-out shadow-xl"
          >
            <NuxtLink :to="'/BlogDetails' + item.id + ''">
              <div class="blog_image rounded-t-3xl overflow-hidden">
                <img
                  class="w-full h-80 sm:h-72 md:h-80 rounded-t-3xl"
                  :src="
                    baseUrl + '/api/attachment/get/'  +
                    item.image +
                    ''
                  "
                  alt=""
                />
              </div>
              <div class="blog_title p-5 sm:p-2 md:p-5 mt-3">
                <h2
                  class="text-2xl font-semibold mb-8 sm:mb-5 md:mb-8 duration-500 ease-in-out"
                >
                  {{ item.title }}
                </h2>
                <hr />
                <div class="flex items-center justify-between">
                  <div class="who_post_blog mt-8 sm:mt-5 md:mt-8 flex items-center gap-5">
                    <div class="who_post_blog_img">
                      <img
                        v-if="item.picture != null"
                        class="w-14 h-14 rounded-full"
                        :src="
                          baseUrl + '/api/attachment/get/' +
                          item.picture +
                          ''
                        "
                        alt=""
                      />
                    </div>
                    <div class="who_post_blog_title">
                      <h4
                        class="font-semibold text-lg"
                        v-if="item.name != null"
                      >
                        {{ item.name }}
                      </h4>
                      <span class="text-sm text-gray-500">
                        {{
                          new Date(item.postedDate).toLocaleDateString(
                            "en-US",
                            { year: "numeric", month: "long", day: "numeric" }
                          )
                        }}
                      </span>
                    </div>
                  </div>
                  <div class="mt-10" v-if="item.offerDate != null">
                    <h2 class="font-semibold text-blue-500 text-lg">
                      Offer Time :
                    </h2>
                    <span class="text-2xl text-red-500">
                      {{ state.countdowns[index] || "Loading..." }}
                    </span>
                  </div>
                </div>
              </div>
            </NuxtLink>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { NuxtLink } from "#components";

const runtimeConfig = useRuntimeConfig();
const baseUrl = runtimeConfig.public.baseURL
console.log(baseUrl);

const state = reactive({
  list: [],
  countdowns: [],
});

onMounted(() => {
  nextTick(async () => {
  getBlogs();
});
});


var getBlogs = async () => {
  const { data } = await useUserAPI("/api/website/getblogs", {
    method: "GET",
  });
  state.list = data.value;
  //console.log(state.list);
  startCountdown();
};

var startCountdown = async () => {
  updateCountdowns(); // Initial update
  setInterval(updateCountdowns, 1000); // Update every second
};

var updateCountdowns = async () => {
  const now = new Date();
  state.countdowns = state.list.map((item) => {
    const offerTime = new Date(item.offerDate);
    const diff = offerTime - now;
    if (diff > 0) {
      const days = Math.floor(diff / (1000 * 60 * 60 * 24));
      const hours = Math.floor((diff / (1000 * 60 * 60)) % 24);
      const minutes = Math.floor((diff / (1000 * 60)) % 60);
      const seconds = Math.floor((diff / 1000) % 60);
      //console.log(`${days} Days ${hours}:${minutes}:${seconds}`);
      return `${days} Days ${hours}:${minutes}:${seconds}`;
    } else {
      return "Offer Expired";
    }
  });
};
</script>

<style scoped>
.headering {
  background: url(/assets/images/banner/banner-3.png) no-repeat center center;
  background-size: cover;
}
h1 {
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 700 !important;
  font-style: normal !important;
}
p {
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 600 !important;
  font-style: normal !important;
}

.offer_card:hover {
  box-shadow: 0px 0px 12px 3px #22222254 !important;
}

.blog_card_box:hover .blog_title h2 {
  color: #1c7df8 !important;
}
.blog_image img {
  transform-origin: center center;
  transition: ease-in-out 500ms;
}
.blog_card_box:hover .blog_image img {
  transform: scale(1.1);
}
</style>
