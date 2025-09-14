<template>
  <div>
    <header
      :class="[
        'nav_bar',
        {
          'floatingNav fixed top-0 right-36 z-50 !bg-blue-500 shadow-lg ease-in-out duration-500':
            isFloating,
        },
      ]"
    >
      <nav>
        <div class="absolute top-0 left-0 w-full z-50 py-5">
          <div class="container mx-auto flex justify-between items-center">
            <!-- Logo -->
            <div>
              <NuxtLink to="/" class="text-2xl font-bold text-white">
                <img class="w-48" src="~/assets/images/Logo.png" alt="Logo" />
              </NuxtLink>
            </div>

            <!-- Mobile Menu Button -->
            <div>
              <button
                @click="isMenuOpen = !isMenuOpen"
                :class="[
                  'menu_btn flex items-center gap-4 px-4 py-1.5  text-lg font-semibold focus:outline-none  duration-500 rounded-lg',
                  isFloating ? 'border border-blue-500 text-blue-500 hover:bg-blue-500 hover:text-slate-100 hover:border-blue-500' : 'border border-transparent text-white hover:bg-slate-100 hover:text-blue-500 hover:border-slate-100'
                ]"
              >
                <span
                  class="bg-slate-100 w-10 h-10 p-2 text-blue-500 rounded-full duration-500 ease-in-out"
                >
                  <svg
                    xmlns="http://www.w3.org/2000/svg"
                    viewBox="0 0 24 24"
                    fill="currentColor"
                    class="size-6"
                  >
                    <path
                      fill-rule="evenodd"
                      d="M3 5.25a.75.75 0 0 1 .75-.75h16.5a.75.75 0 0 1 0 1.5H3.75A.75.75 0 0 1 3 5.25Zm0 4.5A.75.75 0 0 1 3.75 9h16.5a.75.75 0 0 1 0 1.5H3.75A.75.75 0 0 1 3 9.75Zm0 4.5a.75.75 0 0 1 .75-.75h16.5a.75.75 0 0 1 0 1.5H3.75a.75.75 0 0 1-.75-.75Zm0 4.5a.75.75 0 0 1 .75-.75h16.5a.75.75 0 0 1 0 1.5H3.75a.75.75 0 0 1-.75-.75Z"
                      clip-rule="evenodd"
                    />
                  </svg>
                </span>

                Menu
              </button>
            </div>

            <!-- Mobile Navigation Menu -->
            <transition name="slide">
              <nav
                v-show="isMenuOpen"
                class="fixed top-0 right-0 h-screen w-full sm:w-11/12 md:w-1/5 shadow-lg p-4 flex flex-col items-end backdrop-blur-md bg-black/60 z-50"
              >
                <button
                  @click="isMenuOpen = false"
                  class="text-white mb-4 focus:outline-none hover:bg-slate-100 hover:text-blue-500 duration-500 ease-in-out p-2 rounded-full"
                >
                  <svg
                    class="w-6 h-6"
                    fill="none"
                    stroke="currentColor"
                    viewBox="0 0 24 24"
                    xmlns="http://www.w3.org/2000/svg"
                  >
                    <path
                      stroke-linecap="round"
                      stroke-linejoin="round"
                      stroke-width="2"
                      d="M6 18L18 6M6 6l12 12"
                    ></path>
                  </svg>
                </button>
                <ul class="flex flex-col space-y-4 w-full text-right">
                  <li>
                    <NuxtLink
                      to="/"
                      class="block p-4 text-slate-200 hover:underline"
                      >Home</NuxtLink
                    >
                  </li>
                  <li>
                    <NuxtLink
                      to="/about"
                      class="block p-4 text-slate-200 hover:underline"
                      >About</NuxtLink
                    >
                  </li>
                  <li>
                    <NuxtLink
                      to="/Projects"
                      class="block p-4 text-slate-200 hover:underline"
                      >Projects</NuxtLink
                    >
                  </li>
                  <li>
                    <NuxtLink
                      to="/landowner"
                      class="block p-4 text-slate-200 hover:underline"
                      >Landowner</NuxtLink
                    >
                  </li>
                  <li>
                    <NuxtLink
                      to="/blogAndEvents"
                      class="block p-4 text-slate-200 hover:underline"
                      >Blogs & Events</NuxtLink
                    >
                  </li>
                  <li>
                    <NuxtLink
                      to="/gallery"
                      class="block p-4 text-slate-200 hover:underline"
                      >Gallery</NuxtLink
                    >
                  </li>
                  <li>
                    <NuxtLink
                      to="/contact"
                      class="block p-4 text-slate-200 hover:underline"
                      >Contact</NuxtLink
                    >
                  </li>
                </ul>
              </nav>
            </transition>
          </div>
        </div>
      </nav>
    </header>
    <div class="relative w-full">
      <Swiper
        :modules="[SwiperAutoplay, SwiperPagination, SwiperNavigation]"
        :slides-per-view="1"
        :space-between="50"
        :loop="true"
        :pagination="{ clickable: true }"
        :navigation="false"
        :autoplay="{ delay: 3000, disableOnInteraction: false }"
        class="mySwiper w-full"
      >
        <SwiperSlide v-for="(slide, index) in state.slides" :key="index">
          <img v-if="slide !=null && slide.image !=null"
            :src="baseUrl +'/api/attachment/get/' + slide.image"
            alt="Slide Image"
            class="w-full h-[20rem] md:h-[28rem] lg:h-[50rem] brightness-50"
          />
        </SwiperSlide>
      </Swiper>
    </div>
    <div class="absolute 2xl:bottom-20 xl:-bottom-24 md:bottom-3  2xl:inset-x-0 md:left-0 z-10 hidden lg:block">
      <div class="carousel_card w-full lg:w-[47%] md:mx-auto">
        <div class="grid grid-rows-1 grid-flow-col gap-1">
          <div class="box md:!w-[230px] md:!h-[70px] xl:!w-[320px] xl:!h-[295px]">
            <span></span>
            <div class="content backdrop-blur-lg bg-white/50">
              <p class="flex justify-center mb-5">
                <i class="ri-home-8-line md:text-3xl lg:text-5xl text-slate-100"></i>
              </p>
              <p class="text-center md:!text-sm lg:!text-md">
                Clicked here and go to Residential Projects
              </p>
              <NuxtLink :to="'/projecttypeResidential'" class="w-full md:text-sm lg:text-md text-center bg-slate-100"
                >Residential</NuxtLink
              >
            </div>
          </div>
          <div class="box md:!w-[230px] md:!h-[70px] xl:!w-[320px] xl:!h-[295px]">
            <span></span>
            <div class="content backdrop-blur-lg bg-white/50">
              <p class="flex justify-center mb-5">
                <i class="ri-building-4-line  md:text-3xl lg:text-5xl text-slate-100"></i>
              </p>
              <p class="text-center  md:!text-sm lg:!text-md">
                Clicked here and go to Commercial Projects
              </p>
              <NuxtLink :to="'/projecttypeCommercial'" class="w-full  md:!text-sm lg:!text-md text-center">Commercial</NuxtLink>
            </div>
          </div>
          <div class="box md:!w-[230px] md:!h-[70px] xl:!w-[320px] xl:!h-[295px]">
            <span></span>
            <div class="content backdrop-blur-lg bg-white/50">
              <p class="flex justify-center mb-5">
                <i class="ri-map-pin-user-line md:text-3xl lg:text-5xl text-slate-100"></i>
              </p>
              <p class="text-center  md:!text-sm lg:!text-md">
                Clicked here and go to Landowner Projects
              </p>
              <NuxtLink :to="'/LandOwner'" class="w-full  md:!text-sm lg:!text-md text-center">Landowner</NuxtLink>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref } from "vue";
import { Swiper, SwiperSlide } from "swiper/vue";
import "swiper/css";
import "swiper/css/pagination";
import "swiper/css/navigation";
import {
  Autoplay as SwiperAutoplay,
  Pagination as SwiperPagination,
  Navigation as SwiperNavigation,
} from "swiper/modules";
import { onMounted, onUnmounted } from "vue";

  import { useRoute } from 'vue-router';

  const route = useRoute();

const title = computed(() => {
  if (route.name === 'index') return 'Triconproperty';
  return `Triconproperty - ${route.name?.toString().replace('-', ' ')}`;
});

useHead({
  title
});

const runtimeConfig = useRuntimeConfig();
  const baseUrl = runtimeConfig.public.baseURL
  console.log(baseUrl);


const state = reactive({
  slides: [],
});






var getslides = async () => {
  var { data } = await useUserAPI("/api/website/getsliders", {
    method: "GET",
  });
  state.slides = data.value;
};

var isMenuOpen = ref(false);

var isMenuOpen = ref(false);
var isFloating = ref(false);

// Handle scroll event to toggle sticky navigation
var handleScroll = () => {
  if (window.scrollY > 500) {
    isFloating.value = true;
  } else {
    isFloating.value = false;
  }
};

// Add event listener on mount and remove it when unmounted
onMounted(() => {
  window.addEventListener("scroll", handleScroll);
  nextTick(async () => {
  getslides();
});
});
onUnmounted(() => {
  window.removeEventListener("scroll", handleScroll);
});
</script>

<style scoped>
p {
  font-family: "Playfair Display", serif;
  font-optical-sizing: auto;
  font-weight: 400;
  font-style: normal;
}
a {
  font-family: "Playfair Display", serif;
  font-optical-sizing: auto;
  font-weight: 500;
  font-style: normal;
}
h1,
h2,
h3,
h4,
h5,
h6 {
  font-family: "Playfair Display", serif;
  font-optical-sizing: auto;
  font-weight: 600;
  font-style: normal;
}

.slide-enter-active,
.slide-leave-active {
  transition: transform 0.3s ease-in-out, opacity 0.3s ease-in-out;
}
.slide-enter-from,
.slide-leave-to {
  transform: translateX(100%);
  opacity: 0;
}

/* Sticky nav transition */
.floatingNav {
  transition: all 0.3s ease-in-out;
}

.carousel-container {
  max-width: 800px;
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

.box {
  position: relative;
  display: flex;
  justify-content: center;
  align-items: center;
  width: 320px;
  height: 295px;
  transition: 0.5s;
  &:hover {
    &:before,
    &:after {
      left: 20px;
      width: calc(100% - 90px);
      transform: skewX(0deg);
    }
    span {
      &::before {
        top: -50px;
        left: 50px;
        width: 100px;
        height: 100px;
        opacity: 1;
      }
      &::after {
        bottom: -50px;
        right: 50px;
        width: 100px;
        height: 100px;
        opacity: 1;
      }
    }
    .content {
      left: -25px;
      padding: 60px 40px;
    }
  }
  &:nth-child(1) {
    &:before,
    &:after {
      background: linear-gradient(315deg, #ffbc00, #ff0058);
    }
  }
  &:nth-child(2) {
    &:before,
    &:after {
      background: linear-gradient(315deg, #03a9f4, #ff0058);
    }
  }
  &:nth-child(3) {
    &:before,
    &:after {
      background: linear-gradient(315deg, #4dff03, #00d0ff);
    }
  }
  span {
    display: block;
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    z-index: 5;
    pointer-events: none;
    &::before {
      content: "";
      position: absolute;
      top: 0;
      left: 0;
      width: 0;
      height: 0;
      border-radius: 8px;
      background: rgba(255, 255, 255, 0.1);
      backdrop-filter: blur(10px);
      opacity: 0;
      transition: 0.5s;
      animation: animate 2s ease-in-out infinite;
      box-shadow: 0 5px 15px rgba(0, 0, 0, 0.08);
    }
    &::after {
      content: "";
      position: absolute;
      bottom: 0;
      right: 0;
      width: 100%;
      height: 100%;
      border-radius: 8px;
      background: rgba(255, 255, 255, 0.1);
      backdrop-filter: blur(10px);
      opacity: 0;
      transition: 0.5s;
      animation: animate 2s ease-in-out infinite;
      box-shadow: 0 5px 15px rgba(0, 0, 0, 0.08);
      animation-delay: -1s;
    }
  }
  .content {
    position: relative;
    z-index: 1;
    left: 0;
    padding: 20px 40px;
    color: #fff;
    border-radius: 8px;
    backdrop-filter: blur(10px);
    background: rgba(255, 255, 255, 0.3);
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.1);
    transition: 0.5s;
    h2 {
      margin-bottom: 10px;
      font-size: 2em;
      color: #fff;
    }
    p {
      margin-bottom: 10px;
      font-size: 1em;
      font-weight: 300;
      line-height: 1.6em;
    }
    a {
      display: inline-block;
      margin-top: 5px;
      padding: 10px;
      text-decoration: none;
      font-weight: 400;
      color: #fff;
      border-radius: 5px;
      border: 1px solid rgb(255 255 255 / 50%);
      background-color: transparent;
      transition: 0.25s;
      &:hover {
        color: #111;
        background-color: #fff;
      }
    }
  }
}

@keyframes animate {
  0%,
  100% {
    transform: translateY(10px);
  }

  50% {
    transform: translate(-10px);
  }
}

footer {
  position: fixed;
  left: 50%;
  bottom: 30px;
  transform: translateX(-50%);
  p {
    color: #fff;
  }
  a {
    color: #fff;
    text-decoration: none;
  }
}

/* @media only screen and (min-width: 767px) {
  .box[data-v-6ed438bb] {
    position: relative;
    display: flex;
    justify-content: center;
    align-items: center;
    width: 215px;
    height: 170px;
    transition: 0.5s;
}
} */
</style>
