<template>
  <div>
    <div class="headering py-36 sm:py-48 md:py-64 lg:py-72 xl:py-[200px]"></div>
    <div
      class="page_title absolute top-1/4 sm:top-1/3 md:top-2/4 lg:top-2/3 xl:top-3/4 2xl:top-[40%] left-0"
    >
      <h1 class="text-2xl sm:text-3xl md:text-4xl text-slate-100 p-5">
        / About US
      </h1>
    </div>

    <div class="history py-14 px-2">
      <div class="container mx-auto">
        <h1
          class="text-3xl md:text-4xl lg:text-5xl xl:text-6xl text-slate-800 mb-5 lg:mb-8 xl:mb-16"
        >
          Our History
        </h1>
        <div class="w-full">
          <p v-if="state.about != null && state.about.history != null">
            {{ state.about.history }}
          </p>
        </div>
      </div>
    </div>

    <div class="owner_speech py-14 px-2">
      <div class="container mx-auto">
        <h1
          class="text-3xl md:text-4xl lg:text-5xl xl:text-6xl text-slate-800 mb-5 md:mb-16"
        >
          Owner Speech
        </h1>
        <div class="sm:flex items-center gap-5">
          <div
            class="owner_image w-full sm:w-[50%] md:w-[40%] lg:w-[35%] xl:w-[30%]"
          >
            <div>
              <img
                v-if="state.about != null && state.about.ownerImage != null"
                class="h-[250px] md:h-[300px] lg:h-[350px] xl:h-[400px] 2xl:h-[500px] rounded-lg"
                :src="
                  baseUrl + '/api/attachment/get/' + state.about.ownerImage + ''
                "
                alt=""
              />
            </div>
          </div>
          <div
            class="owner_text w-full sm:w-[50%] md:w-[60%] lg:w-[65%] xl:w-[70%]"
          >
            <div class="mb-5">
              <h1
                class="text-xl md:text-2xl text-slate-950"
                v-if="state.about != null && state.about.ownerName != null"
              >
                {{ state.about.ownerName }}
              </h1>
              <p
                class="text-md md:text-lg text-slate-950 font-semibold"
                v-if="
                  state.about != null && state.about.ownerDesignation != null
                "
              >
                {{ state.about.ownerDesignation }}
              </p>
            </div>
            <p>
              <i class="ri-double-quotes-l sm:me-1"></i>
              <span
                v-if="state.about != null && state.about.ownerSpece != null"
              >
                {{ state.about.ownerSpece }}
              </span>
              <i class="ri-double-quotes-r ms-1"></i>
            </p>
          </div>
        </div>
      </div>
    </div>

    <div class="our_vission_mission py-14 px-2">
      <div class="container mx-auto">
        <div class="our_mission md:flex items-center gap-16 mb-10">
          <div class="w-full md:w-[50%] lg:w-[45%] xl:w-[40%]">
            <div>
              <img
                v-if="state.about != null && state.about.messionImage != null"
                class="rounded-xl h-[200px] sm:h-[300px] w-full mb-5 md:mb-0"
                :src="
                  baseUrl +
                  '/api/attachment/get/' +
                  state.about.messionImage +
                  ''
                "
                alt=""
              />
            </div>
          </div>
          <div class="w-full sm:w-[50%] lg:w-[55%] xl:w-[60%]">
            <h1 class="text-2xl text-slate-950 mb-5 lg:mb-7 xl:mb-10">
              Mission
            </h1>
            <p v-if="state.about != null && state.about.mession != null">
              {{ state.about.mession }}
            </p>
          </div>
        </div>
        <div class="our_vission md:flex items-center gap-16">
          <div class="w-full md:w-[50%] lg:w-[55%] xl:w-[60%] mb-5 md:mb-0">
            <h1 class="text-2xl text-slate-950 mb-5 lg:mb-7 xl:mb-10">
              Vission
            </h1>
            <p v-if="state.about != null && state.about.vission != null">
              {{ state.about.vission }}
            </p>
          </div>
          <div class="w-full md:w-[50%] lg:w-[45%] xl:w-[40%]">
            <div>
              <img
                v-if="state.about != null && state.about.vissionImage != null"
                class="rounded-xl h-[200px] sm:h-[300px] w-full"
                :src="
                  baseUrl +
                  '/api/attachment/get/' +
                  state.about.vissionImage +
                  ''
                "
                alt=""
              />
            </div>
          </div>
        </div>
      </div>
    </div>

    <div class="our_team py-14 bg-slate-100 px-2">
      <div class="container mx-auto">
        <h1
          class="text-3xl md:text-4xl lg:text-5xl xl:text-6xl text-slate-800 mb-16"
        >
          Our Team
        </h1>

        <div
          class="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-5 sm:gap-3 md:gap-8"
        >
          <div
            v-for="teamitem in state.team"
            :key="teamitem.id"
            @click="onToggle(teamitem)"
            class="team_card p-5 sm:p-10 border border-slate-100 rounded-3xl shadow-xl bg-white hover:-translate-y-2 duration-500 ease-in-out cursor-pointer hover:border-blue-500"
          >
            <div
              class="team_image mb-8 overflow-hidden rounded-full w-44 sm:w-32 md:w-36 xl:w-44 h-44 sm:h-32 md:h-36 xl:h-44 mx-auto"
            >
              <img
                class="w-44 sm:w-32 md:w-36 xl:w-44 h-44 sm:h-32 md:h-36 xl:h-44"
                :src="baseUrl + '/api/attachment/get/' + teamitem.image + ''"
                alt=""
              />
            </div>
            <div class="team_text">
              <div class="team_title text-center mb-6 sm:mb-3 md:mb-6">
                <h2
                  class="team_name text-2xl sm:text-xl md:text-2xl mb- text-slate-800 font-bold duration-500"
                >
                  {{ teamitem.name }}
                </h2>
                <span
                  class="team_designation font-semibold text-lg sm:text-md md:text-lg text-blue-500"
                >
                  {{ teamitem.designation }}</span
                >
              </div>
              <div
                class="team_description text-center text-md sm:text-sm mb-5 md:mb-6 xl:mb-14"
              >
                <p>
                  {{ teamitem.description }}
                </p>
              </div>
              <div
                class="team_social_media flex items-center justify-center gap-5"
              >
                <NuxtLink
                  :to="teamitem.facebook"
                  class="hover:-translate-y-2 duration-500 ease-in-out"
                  ><span
                    ><i
                      class="ri-facebook-fill text-2xl sm:text-xl xl:text-2xl text-slate-50 bg-blue-500 p-3 sm:p-2 xl:p-3 rounded-full"
                    ></i></span
                ></NuxtLink>

                <NuxtLink
                  :to="teamitem.twiter"
                  class="hover:-translate-y-2 duration-500 ease-in-out"
                >
                  <span
                    ><i
                      class="ri-twitter-x-fill text-2xl sm:text-xl xl:text-2xl text-slate-50 bg-slate-950 p-3 sm:p-2 xl:p-3 rounded-full"
                    ></i
                  ></span>
                </NuxtLink>

                <NuxtLink
                  :to="teamitem.linkthen"
                  class="hover:-translate-y-2 duration-500 ease-in-out"
                >
                  <span
                    ><i
                      class="ri-linkedin-fill text-2xl sm:text-xl xl:text-2xl text-slate-50 bg-blue-700 p-3 sm:p-2 xl:p-3 rounded-full"
                    ></i></span
                ></NuxtLink>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <transition name="" class="">
      <div
        v-if="isModalVisible"
        class="fixed inset-y-0 inset-x-0 flex items-center justify-center z-50"
      >
        <div
          @click="onToggle"
          class="absolute inset-0 bg-black opacity-70 z-0"
        ></div>
        <div
          class="w-[350px] sm:w-full max-w-4xl p-3 relative mx-auto my-auto rounded shadow-lg bg-white animate__animated animate__bounceIn animate__fast"
        >
          <div class="text-end space-x-4 md:block">
            <button
              @click="onToggle"
              class="mb-2 md:mb-0 bg-blue-500 border border-blue-500 px-2.5 py-1 text-sm shadow-sm font-medium tracking-wider text-white rounded hover:shadow-lg hover:bg-blue-600"
            >
              <i class="ri-close-fill text-lg"></i>
            </button>
          </div>
          <div class="p-5 sm:flex items-top gap-5">
            <div class="modal_team_iamge w-full sm:w-[35%] text-center">
              <img
                v-if="state.selectedTeamMember.image"
                class="w-[200px] sm:w-full h-[220px] sm:h-full mx-auto"
                :src="
                  baseUrl +
                  '/api/attachment/get/' +
                  state.selectedTeamMember.image
                "
                alt=""
              />
            </div>
            <div class="modal_team_details w-[65%] px-6">
              <div class="mb-6">
                <h2
                  v-if="
                    state.selectedTeamMember != null &&
                    state.selectedTeamMember.name != null
                  "
                  class="name text-2xl font-bold mb-2"
                >
                  {{ state.selectedTeamMember.name }}
                </h2>
                <span
                  class="font-semibold text-blue-500"
                  v-if="
                    state.selectedTeamMember != null &&
                    state.selectedTeamMember.designation != null
                  "
                >
                  {{ state.selectedTeamMember.designation }}
                </span>
              </div>
              <p
                v-if="
                  state.selectedTeamMember != null &&
                  state.selectedTeamMember.description != null
                "
                class="mb-6"
              >
                {{ state.selectedTeamMember.description }}
              </p>
              <!-- <ul class="mb-10">
                <li class="border-y py-4 flex items-center">
                  <p class="pe-6 w-20">Phone :</p>
                  <span>+8801544-012024</span>
                </li>
                <li class="border-y py-4 flex items-center">
                  <p class="pe-6 w-20">Email :</p>
                  <span>carter@gail.com</span>
                </li>
              </ul> -->
              <div class="team_social_media flex items-center gap-5">
                <a
                  :href="state.selectedTeamMember?.facebook"
                  class="hover:-translate-y-2 duration-500 ease-in-out"
                >
                  <span
                    ><i
                      class="ri-facebook-fill text-xl text-slate-50 bg-blue-500 p-3 rounded-full"
                    ></i
                  ></span>
                </a>
                <a
                  :href="state.selectedTeamMember?.twiter"
                  class="hover:-translate-y-2 duration-500 ease-in-out"
                >
                  <span
                    ><i
                      class="ri-twitter-x-fill text-xl text-slate-50 bg-slate-950 p-3 rounded-full"
                    ></i
                  ></span>
                </a>
                <a
                  :href="state.selectedTeamMember?.linkthen"
                  class="hover:-translate-y-2 duration-500 ease-in-out"
                >
                  <span
                    ><i
                      class="ri-linkedin-fill text-xl text-slate-50 bg-blue-700 p-3 rounded-full"
                    ></i
                  ></span>
                </a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </transition>
  </div>
</template>

<script setup>
import { ref, computed } from "vue";

const runtimeConfig = useRuntimeConfig();
const baseUrl = runtimeConfig.public.baseURL;
console.log(baseUrl);

const state = reactive({
  about: null,
  team: [],
  selectedTeamMember: null,
});

onMounted(() => {
  nextTick(async () => {
    getaboutus();
    getteams();
  });
});

var getaboutus = async () => {
  const { data } = await useUserAPI("/api/aboutus", {
    method: "GET",
  });
  state.about = data.value[0];
};

var getteams = async () => {
  const { data } = await useUserAPI("/api/website/getteams", {
    method: "GET",
  });
  state.team = data.value;
  console.log(state.team);
};

var isOpen = ref(false);

var isModalVisible = computed(() => isOpen.value);

// var onToggle = () => {
//   isOpen.value = !isOpen.value;
// };

var onToggle = (member = null) => {
  console.log(member);
  if (member) {
    state.selectedTeamMember = member;
  }
  isOpen.value = !isOpen.value;
};

useHead({
  link: [
    {
      rel: "stylesheet",
      href: "https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css",
    },
  ],
});
</script>

<style scoped>
.headering {
  background: url(/assets/images/banner/banner-3.png) no-repeat center center;
  background-size: cover;
}

.fade-scale-enter-active,
.fade-scale-leave-active {
  transition: opacity 500ms ease-out, transform 300ms ease-out;
}

.fade-scale-enter,
.fade-scale-leave-to {
  opacity: 0;
  transform: scale(0.9);
}

p {
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 400 !important;
  font-style: normal !important;
}
h1 {
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 700 !important;
  font-style: normal !important;
}
.banner_course_item {
  position: absolute !important;
  top: 100px;
  right: -130px;
  z-index: 999;
}

.team_card:hover .team_name {
  color: #1c7df8 !important;
}
.team_image img {
  transform-origin: center center;
  object-fit: cover;
  transition: ease-in-out 500ms;
}
.team_card:hover .team_image img {
  transform: scale(1.1);
}
.modal_team_iamge img {
  object-fit: cover;
}
</style>
