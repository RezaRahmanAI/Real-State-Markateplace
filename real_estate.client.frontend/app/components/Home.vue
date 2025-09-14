<template>
  <div>
    <div class="projects_explore pt-24 pb-10">
      <div class="container mx-auto">
        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-10 mb-10 md:p-5 lg:p-2 xl:p-0">
          <div
            class="w-full h-[300px] md:h-[400px] lg:h-[500px] overflow-hidden explore_item relative cursor-pointer p-2 md:p-0"
          >
            <NuxtLink :to="'/projectcategoryOngoing'">
              <img
                class="w-full h-full brightness-50 duration-700"
                src="~/assets/images/banner/banner-3.png"
                alt=""
              />
            </NuxtLink>
            <div
              class="absolute top-28 md:top-36 lg:top-52 left-20 sm:left-52 md:left-14 lg:left-9 xl:left-20 h-52 overflow-hidden explore_item_text"
            >
              <NuxtLink  :to="'/projectcategoryOngoing'">
                <p class="text-3xl text-slate-50 mb-5">Ongoing Projects</p>
                <p
                  class="text-lg text-slate-50 text-center translate-y-44 origin-bottom-center duration-700"
                >
                  Explore
                </p>
              </NuxtLink>
            </div>
          </div>
          <div
            class="w-full h-[300px] md:h-[400px] lg:h-[500px] p-2 md:p-0 overflow-hidden explore_item relative cursor-pointer"
          >
            <NuxtLink :to="'/projectcategoryUpcoming'">
              <img
                class="w-full h-full brightness-50 duration-700"
                src="~/assets/images/banner/banner_1.jpg"
                alt=""
              />
            </NuxtLink>
            <div
              class="absolute top-28 md:top-36 lg:top-52 left-16 sm:left-44 md:left-7 lg:left-3 xl:left-14 h-52 overflow-hidden explore_item_text"
            >
              <NuxtLink :to="'/projectcategoryUpcoming'">
                <p class="text-3xl text-slate-50 mb-5">Upcomming Projects</p>
                <p
                  class="text-lg text-slate-50 text-center translate-y-44 origin-bottom-center duration-700"
                >
                  Explore
                </p>
              </NuxtLink>
            </div>
          </div>
          <div
            class="w-full h-[300px] md:h-[400px] lg:h-[500px] p-2 md:p-0 overflow-hidden explore_item relative cursor-pointer"
          >
            <NuxtLink :to="'/projectcategoryCompleted'">
              <img
                class="w-full h-full brightness-50 duration-700"
                src="~/assets/images/banner/banner-3.png"
                alt=""
              />
            </NuxtLink>
            <div
              class="absolute top-28 md:top-36 lg:top-52 inset-x-20 sm:left-48 md:left-9 lg:inset-x-6 xl:left-20 h-52 overflow-hidden explore_item_text"
            >
              <NuxtLink :to="'/projectcategoryCompleted'">
                <p class="text-3xl text-slate-50 mb-5">Complete Projects</p>
                <p
                  class="text-lg text-slate-50 text-center translate-y-44 origin-bottom-center duration-700"
                >
                  Explore
                </p>
              </NuxtLink>
            </div>
          </div>
        </div>

        
      </div>
    </div>

    <div class="project_slide py-10 bg-slate-50 px-2">
      <div class="container mx-auto">
        <div class="flex flex-row justify-between md:mb-16">
          <div class="w-full">
            <div class="mb-10 text-center md:text-start">
              <h1 class="text-4xl lg:text-6xl mb-3 lg:mb-5 text-slate-800">Our Touch</h1>
              <h1 class="text-4xl lg:text-6xl md:ms-16 text-slate-800">of Excellence</h1>
            </div>

            <div class="relative h-[750px]">
              <button
                class="custom-prev absolute left-0 md:left-0 lg:left-2/3 inset-y-28 sm:left-0 sm:top-1/3 md:top-1/4 lg:top-1/4 transform -translate-y-1/2 z-10 bg-blue-500 text-white p-3 w-12 h-12 flex items-center justify-center rounded-full hover:bg-blue-600 hover:shadow-xl hover:shadow-blue-300 duration-500 ease-in-out cursor-pointer md:shadow-lg"
              >
                <i class="ri-arrow-left-double-fill"></i>
              </button>
              <swiper
                :slidesPerView="3"
                :spaceBetween="30"
                :loop="true"
                :speed="600"
                :effect="'slide'"
                :navigation="{ nextEl: '.custom-next', prevEl: '.custom-prev' }"
                :pagination="{ clickable: true }"
                :modules="[SwiperNavigation]"
                :breakpoints="{
                  320: { slidesPerView: 1, spaceBetween: 10 },
                  640: { slidesPerView: 1, spaceBetween: 15 },
                  768: { slidesPerView: 1, spaceBetween: 15 },
                  1024: { slidesPerView: 2, spaceBetween: 20 },
                  1280: { slidesPerView: 3, spaceBetween: 30 }
                }"
                class="mySwiper"
              >
                <swiper-slide  v-for="projectitem in state.list"
                :key="projectitem.id">
                  <div>
                    <NuxtLink :to="`/projectdetails/${projectitem.id}`">
                      <div class="h-full">
                           <img v-if="projectitem !=null && projectitem.thumbnail !=null"
                        class="w-full h-full object-cover"
                        :src="baseUrl + '/api/attachment/get/'+
                    projectitem.thumbnail +
                    ''
                  "
                         alt=""
                      />
                      </div>
                   
                      <div class="project_title mt-5 px-4 lg:px-0">
                        <NuxtLink :to="'/projecttype' + projectitem.type + ''">
                          <p
                            class="text-blue-500 leading-normal text-2xl"
                            style="line-height: 2"
                          >
                          {{ projectitem.name }}
                          </p>
                          <div class="flex items-center gap-3">
                            <p>{{ projectitem.type }}</p>
                            <p class="w-3 h-3 p-1 bg-blue-500 rounded-full"></p>
                            <p>{{ projectitem.address }}</p>
                          </div>
                        </NuxtLink>
                      </div>
                    </NuxtLink>
                  </div>
                </swiper-slide>
              </swiper>

              <button
                class="custom-next absolute right-0 sm:right-[0%] md:right-0 lg:right-[22%] sm:top-1/3 md:top-1/4 lg:top-1/4 transform -translate-y-1/2 z-10 bg-blue-500 text-white p-3 w-12 h-12 flex items-center justify-center rounded-full hover:bg-blue-600 hover:shadow-xl hover:shadow-blue-300 duration-500 ease-in-out md:shadow-lg cursor-pointer"
              >
                <i class="ri-arrow-right-double-fill"></i>
              </button>
            </div>
          </div>
        </div>

        <div
          class="hidden adds items-center justify-between w-2/6 h-20 p-3 bg-blue-500 ring-2 ring-offset-2 ring-blue-500 mx-auto rounded-full shadow-xl"
        >
          <div class="px-4 flex items-center gap-3">
            <i class="ri-bookmark-3-fill text-3xl text-slate-50"></i>
            <span class="text-2xl font-semibold text-slate-50"
              >Get In Touch</span
            >
          </div>
          <div class="">
            <button
              class="bg-slate-50 px-5 py-4 text-blue-500 rounded-full font-semibold hover:bg-slate-100 duration-500 ease-in-out"
            >
              Order Now
            </button>
          </div>
        </div>
      </div>
    </div>

    <div class="vision_banner mb-14 !py-20 md:!py-28 xl:!py-[270px] md:px-2 lg:px-5 lg:!py-36">
      <div class="container mx-auto relative">
        <h1 class="text-4xl lg:text-6xl text-white font-semibold mb-8 text-center md:text-left">
          <span class="mb-5">A Vision For</span> <br />
          <span class="md:ms-16">Luxury Living</span>
        </h1>
        <p class="lg:ms-40 text-slate-50 text-lg text-center md:text-left">
          Founded in 1999, Sanmar Properties has become a pioneer in
          residential, commercial and shopping mall development, as well as,
          land subdivision development. With its headquarters now located in
          Dhaka, Sanmar has grown rapidly in stature due to its pioneering,
          innovative and sustainable approach to real estate development.
        </p>
        <NuxtLink
          class="py-11 lg:py-12 xl:py-16 px-4 lg:px-3 xl:px-6 font-semibold bg-blue-500 text-slate-50 text-md lg:text-xl xl:text-2xl rounded-full absolute -bottom-32 md:-bottom-40 lg:-bottom-48 xl:-bottom-[340px] left-8 lg:left-0 ring-offset-2 ring ring-blue-500 hover:bg-blue-600 duration-500 ease-in-out"
          to="/About"
          >
          Read More
          </NuxtLink
        >
      </div>
    </div>

    <div class="our_projects pt-14 pb-10 md:px-2">
      <div class="container mx-auto">
        <div class="our_project_title mb-14 text-center md:text-left">
          <h1 class="text-4xl lg:text-6xl mb-5 text-slate-800">Our Feature</h1>
          <h1 class="md:ms-32 text-4xl lg:text-6xl text-slate-800">Projects</h1>
        </div>
        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-5 mb-16">
          <div
            v-for="item in state.list"
            :key="item.id"
            class="project_card border rounded-2xl shadow-xl hover:-translate-y-2 hover:ring-1 hover:ring-offset-2 hover:ring-blue-500 duration-500 ease-in-out"
          >
            <NuxtLink :to="'/projectdetails/' + item.id + ''">
              <div class="project_card_img rounded-t-2xl overflow-hidden">
                <img
                  class="w-full h-[450px]  md:h-[350px] lg:h-[380px] xl:h-[450px] rounded-t-2xl object-cever"
                  :src="baseUrl + '/api/attachment/get/' +
                    item.thumbnail +
                    ''
                  "
                  alt=""
                />
              </div>
              <div class="project_card_details p-4 text-center">
                <h1 class="text-2xl font-bold mb-3 duration-500 ease-in-out">
                  {{ item.name }}
                </h1>
                <p
                  class="font-semibold text-gray-500 !flex items-center gap-2 justify-center"
                >
                  <span>{{ item.category }}</span>
                  <span class="w-3 h-3 text-sm bg-gray-500 rounded-full"></span>
                  <span>{{ item.type }}</span>
                </p>
              </div>
            </NuxtLink>
          </div>
        </div>

        
      </div>
    </div>

    <div class="testimonial py-10 bg-gray-100 md:px-2">
      <div class="container mx-auto">
        <div class="testimonial_title mb-14 text-center md:text-left">
          <h1 class="text-4xl lg:text-6xl mb-3 lg:mb-5 text-slate-800">Real People</h1>
          <h1 class="md:ms-16 text-4xl lg:text-6xl text-slate-800">Real Praises</h1>
        </div>
        <div
          class="flex flex-col md:flex-row items-center gap-0 lg:gap-10 bg-white p-6 rounded-lg"
        >
          <!-- Image Section -->
          <div class="w-full md:w-1/3">
            <img v-if="state.testis[currentIndex] !=null && state.testis[currentIndex].image !=null"
              :src="baseUrl + '/api/attachment/get/' +
                state.testis[currentIndex].image
              "
              alt="Customer"
              class="rounded-lg w-full h-[400px] md:h-[300px] lg:h-[400px] xl:h-[500px] object-cover"
            />
          </div>

          <!-- Testimonial Content -->
          <div class="w-full md:w-2/3 p-6">
            <h2 class="text-2xl font-bold text-gray-900">
              What our customers are saying
            </h2>
            <p class="text-gray-500 text-sm">
              Serving over 50k+ customers every month
            </p>

            <div class="bg-gray-100 p-4 rounded-lg mt-4">
              <div class="flex text-yellow-500 mb-2">
                <Icon
                  name="heroicons:star-solid"
                  class="w-5 h-5"
                  v-for="i in 5"
                  :key="i"
                />
              </div>
              <p
                class="text-gray-700"
                v-if="state.testis[currentIndex] != null"
              >
                {{ state.testis[currentIndex].description }}
              </p>
              <div class="mt-4">
                <p
                  class="font-semibold text-gray-900 text-lg"
                  v-if="state.testis[currentIndex] != null"
                >
                  {{ state.testis[currentIndex].name }}
                </p>
                <!-- <p class="text-blue-600 text-sm">
                  {{ testimonials[currentIndex].position }}
                </p> -->
              </div>
            </div>
            <div class="flex items-center mt-4 space-x-4">
              <button
                @click="prevTestimonial"
                class="w-10 h-10 rounded-full text-gray-600 hover:bg-blue-500 hover:text-slate-100 duration-500 ease-in-out"
              >
                ←
              </button>
              <p class="text-gray-600">
                {{ currentIndex + 1 }} of {{ state.testis.length }}
              </p>
              <button
                @click="nextTestimonial"
                class="w-10 h-10 rounded-full text-gray-600 hover:bg-blue-500 hover:text-slate-100 duration-500 ease-in-out"
              >
                →
              </button>
            </div>
          </div>
        </div>

        <div
          class="hidden adds items-center justify-between w-2/6 h-20 p-3 bg-blue-500 ring-2 ring-offset-2 ring-blue-500 mx-auto rounded-full shadow-xl"
        >
          <div class="px-4 flex items-center gap-3">
            <i class="ri-bookmark-3-fill text-3xl text-slate-50"></i>
            <span class="text-2xl font-semibold text-slate-50"
              >Get In Touch</span
            >
          </div>
          <div class="">
            <button
              class="bg-slate-50 px-5 py-4 text-blue-500 rounded-full font-semibold hover:bg-slate-100 duration-500 ease-in-out"
            >
              Booking Now
            </button>
          </div>
        </div>
      </div>
    </div>

    <transition name="" class="z-50 ">
      <div
       v-if="isModalVisible && state.offer && state.offer.picture"
        class="fixed inset-y-0 inset-x-0 flex items-center justify-center"
      >
        <div
          @click="isOpen = false"
          class="absolute inset-0 bg-black opacity-70"
        ></div>
        <div
          class="w-[500px] sm:w-[550px] md:w-[600px] lg:w-[650px] xl:w-full max-w-4xl p-3 relative mx-auto my-auto rounded shadow-lg bg-white animate__animated animate__bounceIn animate__fast"
        >
          <div class="text-end space-x-4 md:block">
            <button
              @click="onToggle"
              class="mb-2 md:mb-0 bg-blue-500 border border-blue-500 px-2.5 py-1 text-sm shadow-sm font-medium tracking-wider text-white rounded hover:shadow-lg hover:bg-blue-600"
            >
              <i class="ri-close-fill text-lg"></i>
            </button>
          </div>
          <div class="p-5 gap-5 ">
            <img v-if="state.offer !=null && state.offer.picture !=null" class="w-full h-[400px] sm:h-[450px] md:h-[500px] lg:h-[550px] xl:h-[600px] 2xl:h-[650px]"  :src="baseUrl + '/api/attachment/get/' +
                state.offer.picture
              " alt="">
          </div>
        </div>
      </div>
    </transition>
  </div>
</template>

<script setup>
import { ref } from "vue";
import { Swiper, SwiperSlide } from "swiper/vue";
import "swiper/css";
import { Navigation as SwiperNavigation } from "swiper/modules";
  const runtimeConfig = useRuntimeConfig();
  const baseUrl = runtimeConfig.public.baseURL
  console.log(baseUrl);


const state = reactive({
  testis: [],
  list: [],
  offer:null,
});

onMounted(() => {
  nextTick(async () => {
    getOffer();
    getProject();
    gettestimonials();
});
});

var getOffer = async () => {
  var { data } = await useUserAPI("/api/website/getoffers", {
    method: "GET",
  });
  state.offer = data.value;
  console.log(state.offer);   
};

var getProject = async () => {
  var { data } = await useUserAPI("/api/website/getprojects", {
    method: "GET",
  });
  state.list = data.value;
};

var gettestimonials = async () => {
  const { data } = await useUserAPI("/api/website/gettestimonials", {
    method: "GET",
  });
  state.testis = data.value;
};

var currentIndex = ref(0);

var prevTestimonial = () => {
  if (currentIndex.value > 0) {
    currentIndex.value--;
  } else {
    currentIndex.value = state.testis.length - 1;
  }
};

var nextTestimonial = () => {
  if (currentIndex.value < state.testis.length - 1) {
    currentIndex.value++;
  } else {
    currentIndex.value = 0;
  }
};



var isOpen = ref(true);

var isModalVisible = computed(() => isOpen.value);

var onToggle = (member = null) => {
  console.log(member);
  if (member && member.picture) {
    state.selectedTeamMember = member;
    isOpen.value = true;
  } else {
    isOpen.value = false;
  }
};

useHead({
  link: [
    {
      rel: "stylesheet",
      href: "https://cdnjs.cloudflare.com/ajax/libs/remixicon/4.6.0/remixicon.min.css",
    },
    {
      rel: "stylesheet",
      href: "https://fonts.googleapis.com",
    },
    {
      rel: "stylesheet",
      href: "https://fonts.gstatic.com",
    },
    {
      rel: "stylesheet",
      href: "https://fonts.googleapis.com/css2?family=Playfair+Display:ital,wght@0,400..900;1,400..900&display=swap",
    },
    {
      rel: "stylesheet",
      href: "https://fonts.googleapis.com/css2?family=Playfair+Display:wght@700&display=swap",
    },
    {
      rel: "stylesheet",
      href: "https://fonts.googleapis.com/css2?family=Playfair+Display:wght@600&display=swap",
    },
  ],
});
var testimonials = ref([
  {
    image: "_nuxt/assets/images/employee/employee-1.jpg",
    name: "Harsh P.",
    position: "Product Designer",
    review:
      "As a busy professional, I don't have a lot of time to manage my investments, but pagedone has made it possible for me to stay on top of my portfolio and make informed decisions quickly and easily.",
  },
  {
    image: "_nuxt/assets/images/employee/employee-2.jpg",
    name: "Sarah K.",
    position: "Marketing Manager",
    review:
      "Pagedone has revolutionized how I handle my investments. It's easy to use and provides real-time insights, which have been game-changers for me.",
  },
  {
    image: "_nuxt/assets/images/employee/employee-3.jpg",
    name: "John D.",
    position: "Entrepreneur",
    review:
      "I love how pagedone keeps everything organized. I can track my investments effortlessly and make data-driven decisions with confidence.",
  },
  {
    image: "_nuxt/assets/images/employee/employee-1.jpg",
    name: "Lisa M.",
    position: "Software Engineer",
    review:
      "With pagedone, I no longer feel lost in managing my portfolio. It's the best tool I've used so far, and I highly recommend it.",
  },
]);

var currentIndex = ref(0);

var prevTestimonial = () => {
  if (currentIndex.value > 0) {
    currentIndex.value--;
  } else {
    currentIndex.value = testimonials.value.length - 1;
  }
};

var nextTestimonial = () => {
  if (currentIndex.value < testimonials.value.length - 1) {
    currentIndex.value++;
  } else {
    currentIndex.value = 0;
  }
};
</script>

<style scoped>
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

.nuxt-devtools-panel {
  display: none !important;
}
.carousel-container {
  max-width: 100%;
  margin: auto;
  padding: 20px;
}

.slide-enter-active,
.slide-leave-active {
  transition: transform 0.3s ease-in-out;
}
.slide-enter-from,
.slide-leave-to {
  transform: translateX(100%);
}

.vision_banner {
  background: url(~/assets/images/banner/banner-3.png) no-repeat center center;
  background-size: cover;
  position: relative;
}
.explore_item a img {
  transform-origin: center center;
  object-fit: cover;
}
.explore_item:hover a img {
  transform: scale(1.1);
}
.explore_item:hover .explore_item_text p:nth-child(2) {
  transform: translateY(0);
}
/* .swiper-slide-active {
  width: 100% !important;
}
.swiper-slide-active img {
  transition: ease-in-out 500ms !important;
  height: 700px !important;
}
.swiper-slide {
  margin-top: auto !important; 
  transition: 500ms;
} */
/* All slides default to 500px */
.swiper-slide img {
  transition: transform 0.6s ease-in-out, height 0.6s ease-in-out;
  height: 500px;
}

/* Active slide becomes 700px */
.swiper-slide-active img{
  height: 650px !important;
}
.swiper-slide {
  transform: scale(0.9);
  transition: transform 0.5s ease;
}

.swiper-slide-active {
  transform: scale(1);
}
.swiper-wrapper {
  position: relative;
}
.swiper-button-next,
.swiper-button-prev {
  color: white !important; /* Change button color */
  background-color: rgba(0, 0, 0, 0.5) !important; /* Add background */
  padding: 10px !important;
  border-radius: 50% !important;
  width: 40px !important;
  height: 40px !important;
}

/* Move buttons closer to the center */
.swiper-button-next {
  right: -50px !important; /* Adjust to move right */
}

.swiper-button-prev {
  left: -50px !important; /* Adjust to move left */
}

.project_card_img img {
  filter: brightness(0.5);
  transform-origin: center center;
  transition: ease-in-out 500ms;
}
.project_card:hover .project_card_img img {
  transform: scale(1.1);
  filter: brightness(0.8);
}
.project_card:hover .project_card_details {
  color: #1b85ff;
}

@media only screen and (max-width: 640px) {
  .swiper-slide-active {
    width: 100% !important;
  }
  .swiper-slide-active img {
    transition: ease-in-out 500ms !important;
    height: 225px !important;
  }
  .swiper-slide {
    margin-top: 0 !important;
    transition: 500ms;
  }
}
@media only screen and (max-width: 768px) {
  .swiper-slide-active {
    width: 100% !important;
  }
  .swiper-slide-active img {
    transition: ease-in-out 500ms !important;
    height: 325px !important;
  }
  .swiper-slide {
    margin-top: 0 !important;
    transition: 500ms;
  }
}
@media only screen and (min-width: 768px) {
  .swiper-slide-active {
    width: 60% !important;
  }
  .swiper-slide-active img {
    transition: ease-in-out 500ms !important;
    height: 550px !important;
  }
  .swiper-slide {
    margin-top: 0 !important;
    transition: 500ms;
  }
}
@media only screen and (min-width: 1024px) {
  .swiper-slide-active {
    width: 60% !important;
  }
  .swiper-slide-active img {
    transition: ease-in-out 500ms !important;
    height: 550px !important;
  }
  .swiper-slide {
    margin-top: auto !important;
    transition: 500ms;
  }
}
@media only screen and (min-width: 1024px) {
  .swiper-slide-active {
    width: 50% !important;
  }
  .swiper-slide-active img {
    transition: ease-in-out 500ms !important;
    height: 600px !important;
  }
  .swiper-slide {
    margin-top: auto !important;
    transition: 500ms;
  }
}
@media only screen and (min-width: 1280px) {
  .swiper-slide-active {
    width: 45% !important;
  }
  .swiper-slide-active img {
    transition: ease-in-out 500ms !important;
    height: 700px !important;
  }
  .swiper-slide {
    margin-top: auto !important;
    transition: 500ms;
  }
}
</style>
