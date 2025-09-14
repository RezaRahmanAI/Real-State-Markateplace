
<template>
    <CommonHeader/>
    <div class="headering"></div>
    <div class="page_title absolute top-3/4 left-0">
      <h1 class="text-4xl text-slate-100 p-5">/ Porojects</h1>
    </div>
    <input
      class="hidden"
      type="text"
      id="typeId"
      name="typeId"
      :value="$route.params.type"
    />
    <div class="projects_search_bar py-8 bg-slate-50">
      <div class="container mx-auto">
        <div class="grid grid-cols-4 gap-5 items-end">
          <div>
            <form class="max-w-sm mx-auto">
              <label
                for="category"
                class="block mb-2 text-sm font-medium text-gray-900 "
                >Select Project Category</label
              >
              <select
                id="category"
                name="category"
                class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 "
              >
                <option selected value="all">Choose a category</option>
                <option value="Ongoing">Ongoing</option>
                <option value="Upcoming">Upcoming</option>
                <option value="Completed">Completed</option>
              </select>
            </form>
          </div>
          <div>
            <form class="max-w-sm mx-auto">
              <label
                for="type"
                class="block mb-2 text-sm font-medium text-gray-900"
                >Select Project Type</label
              >
              <select
                id="type"
                name="type"
                class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5"
              >
                <option selected value="all">Choose a type</option>
                <option value="Residential">Residential</option>
                <option value="Commercial">Commercial</option>
              </select>
            </form>
          </div>
          <div class="hidden">
            <form class="max-w-sm mx-auto">
              <label
                for="location"
                class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                >Select Location</label
              >
              <select
                id="location"
                name="location"
                class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
              >
                <option selected value="all">Choose location</option>
                <option value="Dhaka">Dhaka</option>
                <option value="Rajshahi">Rajshahi</option>
                <option value="Chattagram">Chattagram</option>
                <option value="Rangpur">Rangpur</option>
              </select>
            </form>
          </div>
          <div class="filter_btn">
            <button
              @click="getProject()"
              class="border-dashed border-2 border-gray-400 py-2 px-5 rounded-lg hover:bg-gray-400 hover:text-slate-100 duration-500 ease-in-out"
            >
              <i class="ri-filter-2-line"></i>
              Filter
            </button>
          </div>
        </div>
      </div>
    </div>

    <div class="project_section py-10">
      <div class="container mx-auto">
        <div class="grid grid-cols-3 gap-5">
          <div  v-for="item in state.list"
          :key="item.id" class="project_card border rounded-2xl shadow-xl hover:-translate-y-2 hover:ring-1 hover:ring-offset-2 hover:ring-blue-500 duration-500 ease-in-out">
                <NuxtLink :to="'/projectdetails/' + item.id + ''">
                    <div class="project_card_img rounded-t-2xl overflow-hidden">
                        <img class="w-full h-[450px] rounded-t-2xl object-cever"  :src="
                    baseUrl + '/api/attachment/get/' +
                    item.thumbnail +
                    ''
                  "
                  alt="">
                    </div>
                    <div class="project_card_details p-4 text-center">
                        <h1 class="text-2xl font-bold mb-3 duration-500 ease-in-out">   {{ item.name }}</h1>
                        <p class="font-semibold text-gray-500 !flex items-center gap-2 justify-center">
                            <span>{{ item.category }}</span> <span class="w-3 h-3 text-sm bg-gray-500 rounded-full"></span> <span>{{ item.type }}</span>
                        </p>
                    </div>
                </NuxtLink>
            </div>
            
        </div>
      </div>
    </div>
    <Footer />
  </template>
  
  <script setup>
  import { NuxtLink } from '#components';

  const runtimeConfig = useRuntimeConfig();
  const baseUrl = runtimeConfig.public.baseURL
  console.log(baseUrl);
  var state = reactive({
  list: [],
});
  onMounted(() => {
      nextTick(async () => {
      var type = document.getElementById("typeId").value;
      document.getElementById("type").value=type
      getProject();
    });
  });






var getProject = async () => {
  var category = document.getElementById("category").value;
  var type = document.getElementById("type").value;
  var location = document.getElementById("location").value;

  var { data } = await useUserAPI(
    "/api/website/getprojects?category=" +
      category +
      "&type=" +
      type +
      "&location=" +
      location +
      "",
    {
      method: "GET",
    }
  );
  state.list = data.value;
  console.log(state.list);
};
  </script>
  
 
<style scoped>
.headering{
    background: url(/assets/images/banner/banner-3.png) no-repeat center center;
    background-size: cover;
    padding: 400px 0;
}

.project_card_img img{
    filter: brightness(.50);
    transform-origin: center center;
    transition: ease-in-out 500ms;
}
.project_card:hover .project_card_img img{
    transform: scale(1.1);
    filter: brightness(.80);
}
.project_card:hover .project_card_details{
    color: #1b85ff;
}
</style>

  