<template>
  <div>
    <div class="headering py-36 sm:py-48 md:py-64 lg:py-72 xl:py-[400px]"></div>
    <div class="page_title absolute top-1/4 sm:top-1/3 md:top-2/4 lg:top-2/3 xl:top-3/4 2xl:top-[80%] left-0">
      <h1 class="text-2xl sm:text-3xl md:text-4xl text-slate-100 p-5">/ Blog Details</h1>
    </div>

    <div class="offer_time_bar absolute top-24 sm:top-28 md:top-40 lg:top-1/4 xl:top-1/3 left-[0%] right-[0%]" v-if="state.offerActive">
      <h2 class="text-slate-200 text-2xl sm:text-3xl md:text-4xl xl:text-5xl font-bold text-center">Offer Time</h2>
      <div class="mt-8 text-center"  v-if="typeof state.countdown !== 'string'">
        <span class="py-2 md:py-2.5 px-3.5 md:px-4 bg-slate-100 text-xl md:text-2xl lg:text-3xl xl:text-4xl font-bold text-blue-500 rounded me-3">{{ state.countdown?.days }}</span>
        <span class="py-2 md:py-2.5 px-3.5 md:px-4 bg-slate-100 text-xl md:text-2xl lg:text-3xl xl:text-4xl font-bold text-blue-500 rounded me-3">{{ state.countdown?.hours }}</span>
        <span class="py-2 md:py-2.5 px-3.5 md:px-4 bg-slate-100 text-xl md:text-2xl lg:text-3xl xl:text-4xl font-bold text-blue-500 rounded me-3">{{ state.countdown?.minutes }}</span>
        <span class="py-2 md:py-2.5 px-3.5 md:px-4 bg-slate-100 text-xl md:text-2xl lg:text-3xl xl:text-4xl font-bold text-blue-500 rounded">{{ state.countdown?.seconds }}</span>
      </div>
    </div>
    <input
      class="hidden"
      type="text"
      id="blogId"
      name="blogId"
      :value="$route.params.id"
    />
    <div class="blog_details_section py-14 px-4">
      <div class="lg:container mx-auto">
        <div class="sm:flex flex-row sm:items-top gap-8">
          <div class="w-full sm:w-[50%] md:w-[55%] lg:w-[60%] xl:w-[70%] mb-10 sm:mb-0">
            <h1
              class="text-3xl md:text-4xl lg:text-5xl xl:text-6xl mb-5 lg:mb-7 xl:mb-10 text-slate-900"
              v-if="state.data != null && state.data.title != null"
            >
              {{ state.data.title }}
            </h1>
            <div class="pe-14">
              <p v-if="state.data != null && state.data.description != null">
                {{ state.data.description }}
              </p>
            </div>
          </div>
          <div class="w-full sm:w-[50%] md:w-[45%] lg:w-[40%] xl:w-[30%]">
            <div
              class="blog_card_boxD border rounded-3xl cursor-pointer border-blue-500 shadow-xl sticky top-0 z-20"
            >
              <div class="blog_imageD rounded-t-3xl overflow-hidden">
                <img
                  v-if="state.data != null && state.data.image != null"
                  class="w-full h-72 sm:h-56 md:h-72 lg:h-72 xl:h-80 rounded-t-3xl"
                  :src="
                    baseURL + '/api/attachment/get/' +
                    state.data.image +
                    ''
                  "
                  alt=""
                />
              </div>
              <div class="blog_titleD p-5 mt-3">
                <h2
                  class="text-2xl font-semibold mb-8 text-blue-500"
                  v-if="state.data != null && state.data.title != null"
                >
                  {{ state.data.title }}
                </h2>
                <hr />
                <div class="flex items-center justify-between">
                  <div class="who_post_blogD mt-8 flex items-center gap-5">
                    <div class="who_post_blog_imgD">
                      <img
                        v-if="state.data != null && state.data.picture != null"
                        class="w-14 h-14 rounded-full"
                        :src="
                          baseURL + '/api/attachment/get/' +
                          state.data.picture +
                          ''
                        "
                        alt=""
                      />
                    </div>
                    <div class="who_post_blog_titleD">
                      <h4
                        class="font-semibold text-lg"
                        v-if="state.data != null && state.data.name != null"
                      >
                        {{ state.data.name }}
                      </h4>
                      <span
                        class="text-sm text-gray-500"
                        v-if="
                          state.data != null && state.data.postedDate != null
                        "
                        >{{
                          new Date(state.data.postedDate).toLocaleDateString(
                            "en-US",
                            { year: "numeric", month: "long", day: "numeric" }
                          )
                        }}</span
                      >
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <div class="others_blog_list py-14 px-4">
      <div class="lg:container mx-auto">
        <div class="flex items-center justify-between mb-16">
          <h1 class="text-3xl md:text-4xl lg:text-5xl xl:text-6xl text-slate-900">
            Others Blog Post
          </h1>
          <NuxtLink to="/OfferPage">
            <span
              class="font-semibold p-4 text-blue-500 border border-blue-500 rounded-xl hover:bg-blue-500 hover:text-slate-100 duration-500 ease-in-out"
              >View All Blog</span
            >
          </NuxtLink>
        </div>

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
                    baseURL + '/api/attachment/get/'+
                    item.image +
                    ''
                  "
                  alt=""
                />
              </div>
              <div class="blog_title p-5 mt-3">
                <h2
                  class="text-2xl font-semibold mb-8 duration-500 ease-in-out"
                >
                  {{ item.title }}
                </h2>
                <hr />
                <div class="flex items-center justify-between">
                  <div class="who_post_blog mt-8 flex items-center gap-5">
                    <div class="who_post_blog_img">
                      <img
                        v-if="item.picture != null"
                        class="w-14 h-14 rounded-full"
                        :src="
                          baseURL + '/api/attachment/get/' +
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
const baseURL = runtimeConfig.public.baseURL
console.log(baseURL);
// console.log($route.params.id);

const state = reactive({
  list: [],
  data: null,
  countdowns: [],
  countdown: null,
  offerActive: true,
});

onMounted(() => {
  nextTick(async () => {
  getBlog();
  getBlogs();
});
});


var getBlog = async () => {
  var blogId = document.getElementById("blogId").value;
  const { data } = await useUserAPI(
    "/api/website/getsingleblog?blogId=" + blogId + "",
    {
      method: "GET",
    }
  );
  state.data = data.value;
  //console.log(state.data);
};

var getBlogs = async () => {
  var { data } = await useUserAPI("/api/website/getblogs", {
    method: "GET",
  });
  state.list = data.value;
  startCountdown();
};

var startCountdown = async () => {
  updateCountdowns();
  setInterval(updateCountdowns, 1000); 
};
var updateCountdowns = () => {
  
  const now = new Date();

  if (!state.data || !state.data.offerDate) {
    state.offerActive = false;
    state.countdown = null;
  } else {
    const offerTime = new Date(state.data.offerDate);
    const diff = offerTime - now;

    if (diff > 0) {
      const days = Math.floor(diff / (1000 * 60 * 60 * 24));
      const hours = Math.floor((diff / (1000 * 60 * 60)) % 24);
      const minutes = Math.floor((diff / (1000 * 60)) % 60);
      const seconds = Math.floor((diff / 1000) % 60);

      state.countdown = {
        days: String(days).padStart(2, "0"),
        hours: String(hours).padStart(2, "0"),
        minutes: String(minutes).padStart(2, "0"),
        seconds: String(seconds).padStart(2, "0"),
      };

      state.offerActive = true;
    } else {
      state.countdown = {
        days: "00",
        hours: "00",
        minutes: "00",
        seconds: "00",
      };
      state.offerActive = false;
    }
  }

  state.countdowns = state.list.map((item) => {
    if (!item.offerDate) return "No Offer";

    const itemOfferTime = new Date(item.offerDate);
    const diff2 = itemOfferTime - now;

    if (diff2 > 0) {
      const days = Math.floor(diff2 / (1000 * 60 * 60 * 24));
      const hours = Math.floor((diff2 / (1000 * 60 * 60)) % 24);
      const minutes = Math.floor((diff2 / (1000 * 60)) % 60);
      const seconds = Math.floor((diff2 / 1000) % 60);

      return `${String(days).padStart(2, "0")} Days ${String(hours).padStart(2, "0")}:${String(minutes).padStart(2, "0")}:${String(seconds).padStart(2, "0")}`;
    } else {
      return "Offer Expired";
    }
  });
};

</script>

<style scoped>
h1 {
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 700 !important;
  font-style: normal !important;
}
.headering {
  background: url(/assets/images/banner/banner-3.png) no-repeat center center;
  background-size: cover;
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
