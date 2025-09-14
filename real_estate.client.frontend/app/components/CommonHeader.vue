<template>
  <header :class="[
        'nav_bar',
        {
          'floatingNav fixed top-0 right-36 z-40  shadow-lg ease-in-out duration-500':
            isFloating,
        },
      ]">
    <div class="relative">
        <div class="absolute top-0 left-0 w-full bg-transparent z-50 py-8">
            <div class="md:container md:mx-auto flex justify-between items-center">
              <div>
                <NuxtLink to="/" class="text-2xl font-bold text-white">
                  <img class="w-32 md:w-48" src="~/assets/images/Logo.png" alt="Logo">
                </NuxtLink>
              </div>
              <div class="">
                <button @click="isMenuOpen = !isMenuOpen" 
                :class="[
                  'menu_btn flex items-center gap-4 px-4 py-1.5  text-lg font-semibold focus:outline-none  duration-500 rounded-lg',
                  isFloating ? 'border border-blue-500 text-blue-500 hover:bg-blue-500 hover:text-slate-100 hover:border-blue-500' : 'border border-transparent text-white hover:bg-slate-100 hover:text-blue-500 hover:border-slate-100'
                ]"
                >
                  <span class="bg-slate-100 w-10 h-10 p-2 text-blue-500 rounded-full duration-500 ease-in-out">
                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" fill="currentColor" class="size-6">
                      <path fill-rule="evenodd" d="M3 5.25a.75.75 0 0 1 .75-.75h16.5a.75.75 0 0 1 0 1.5H3.75A.75.75 0 0 1 3 5.25Zm0 4.5A.75.75 0 0 1 3.75 9h16.5a.75.75 0 0 1 0 1.5H3.75A.75.75 0 0 1 3 9.75Zm0 4.5a.75.75 0 0 1 .75-.75h16.5a.75.75 0 0 1 0 1.5H3.75a.75.75 0 0 1-.75-.75Zm0 4.5a.75.75 0 0 1 .75-.75h16.5a.75.75 0 0 1 0 1.5H3.75a.75.75 0 0 1-.75-.75Z" clip-rule="evenodd" />
                    </svg>
                  </span>
                  Menu
                </button>
              </div>
            <transition name="slide">
                <nav v-show="isMenuOpen" class="fixed top-0 right-0 h-screen w-full sm:11/12 md:w-72 lg:w-1/4 shadow-lg p-4 flex flex-col items-end backdrop-blur-md bg-black/60 z-50">
                    <button @click="isMenuOpen = false" class="text-white mb-4 focus:outline-none hover:bg-slate-100 hover:text-blue-500 duration-500 ease-in-out p-2 rounded-full">
                        <svg class="w-6 h-6" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                            <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M6 18L18 6M6 6l12 12"></path>
                        </svg>
                    </button>
                    <ul class="flex flex-col space-y-4 w-full text-right">
                        <li><NuxtLink to="/" class="block p-4 text-slate-200 hover:underline">Home</NuxtLink></li>
                        <li><NuxtLink to="/About" class="block p-4 text-slate-200 hover:underline">About</NuxtLink></li>
                        <li><NuxtLink to="/Projects" class="block p-4 text-slate-200 hover:underline">Projects</NuxtLink></li>
                        <li><NuxtLink to="/LandOwner" class="block p-4 text-slate-200 hover:underline">Land Owner</NuxtLink></li>
                        <li><NuxtLink to="/BlogAndEvents" class="block p-4 text-slate-200 hover:underline">Blogs & Events</NuxtLink></li>
                        <li><NuxtLink to="/Gallery" class="block p-4 text-slate-200 hover:underline">Gallery</NuxtLink></li>
                        <li><NuxtLink to="/Contact" class="block p-4 text-slate-200 hover:underline">Contact</NuxtLink></li>
                    </ul>
                </nav>
            </transition>
        </div>
    </div>
    </div>
  </header>
  
</template>

<script setup>
    import { ref } from 'vue';
  import { useRoute } from 'vue-router';

  const route = useRoute();

 
const title = computed(() => {
  if (route.name === 'index') return 'Triconproperty';
  return `Triconproperty - ${route.name?.toString().replace('-', ' ')}`;
});

useHead({
  title
});
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
 
});
onUnmounted(() => {
  window.removeEventListener("scroll", handleScroll);
});

    useHead({
    link: [
      { 
        rel: 'stylesheet',
        href: 'https://cdnjs.cloudflare.com/ajax/libs/remixicon/4.6.0/remixicon.min.css'
      },
      {
        rel: 'stylesheet',
        href: 'https://fonts.googleapis.com'
      },
      {
        rel: 'stylesheet',
        href: 'https://fonts.gstatic.com'
      },
      {
        rel: 'stylesheet',
        href: 'https://fonts.googleapis.com/css2?family=Playfair+Display:ital,wght@0,400..900;1,400..900&display=swap'
      },
      {
        rel: 'stylesheet',
        href: 'https://fonts.googleapis.com/css2?family=Playfair+Display:wght@700&display=swap'
      },
      {
        rel: 'stylesheet',
        href: 'https://fonts.googleapis.com/css2?family=Playfair+Display:wght@600&display=swap'
      },
      {
        rel: 'stylesheet',
        href: 'https://cdnjs.cloudflare.com/ajax/libs/tabler-icons/3.28.1/tabler-icons.min.css'
      }
    ]
})
</script>

<style scoped>
.slide-enter-active, .slide-leave-active {
  transition: transform 0.3s ease-in-out;
}
.slide-enter-from, .slide-leave-to {
  transform: translateX(100%);
}
p{
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 400 !important;
  font-style: normal !important;
}
a{
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 600 !important;
  font-style: normal !important;
}
h1{
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 700 !important;
  font-style: normal !important;
}
    /* header{
        background: url(/assets/images/banner/banner-3.png) no-repeat center center;
        background-size: cover;
        padding: 400px 0;
    } */
</style>