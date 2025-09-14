<template>
  <div class="">
      <div class="flex items-center mb-1">
    <h6 class="text-15 grow font-bold">Project Features</h6>
    <div class="shrink-0">
     <input class="hidden" type="text" id="projectId" name="projectId" :value=" $route.params.id"/>
      <!-- <NuxtLink
        to="/admin/project"
        class="m-2 px-5 py-1 text-white btn bg-orange-600 border-orange-500 hover:text-white hover:bg-orange-600 hover:border-orange-600 focus:text-white focus:bg-orange-600 focus:border-orange-600 focus:ring focus:ring-orange-100 active:text-white active:bg-orange-600 active:border-orange-600 active:ring active:ring-orange-100 dark:ring-orange-400/20"
      >
        <span class="align-middle">Back</span>
      </NuxtLink> -->
      <button
        id="defaultModalButton"
        data-modal-toggle="defaultModal"
        data-modal-target="defaultModal"
        type="button"
        class="m-2 px-5 py-1 text-white btn bg-cyan-600 border-cyan-500 hover:text-white hover:bg-cyan-600 hover:border-cyan-600 focus:text-white focus:bg-cyan-600 focus:border-cyan-600 focus:ring focus:ring-cyan-100 active:text-white active:bg-cyan-600 active:border-cyan-600 active:ring active:ring-cyan-100 dark:ring-cyan-400/20"
      >
        <span class="align-middle">Add</span>
      </button>
    </div>
    </div>
      
          <div
      id="defaultModal"
      tabindex="-1"
      aria-hidden="true"
      class="hidden overflow-y-auto overflow-x-hidden fixed top-20 right-0 left-0 z-50 justify-center items-center w-full md:inset-0 h-[calc(100%-1rem)] max-h-full"
    >
      <div class="relative p-4 w-full max-w-2xl h-full">
        <div
          class="relative p-4 bg-white rounded-lg shadow dark:bg-gray-800 sm:p-5"
        >
          <div
            class="flex justify-between items-center pb-4 mb-4 rounded-t border-b sm:mb-5 dark:border-gray-600"
          >
            <h3 class="text-lg font-semibold text-gray-900 dark:text-white">
              Add Feature
            </h3>
            <button
              type="button"
              class="text-gray-400 bg-transparent hover:bg-gray-200 hover:text-gray-900 rounded-lg text-sm p-1.5 ml-auto inline-flex items-center dark:hover:bg-gray-600 dark:hover:text-white"
              data-modal-toggle="defaultModal"
            >
              <svg
                aria-hidden="true"
                class="w-5 h-5"
                fill="currentColor"
                viewBox="0 0 20 20"
                xmlns="http://www.w3.org/2000/svg"
              >
                <path
                  fill-rule="evenodd"
                  d="M4.293 4.293a1 1 0 011.414 0L10 8.586l4.293-4.293a1 1 0 111.414 1.414L11.414 10l4.293 4.293a1 1 0 01-1.414 1.414L10 11.414l-4.293 4.293a1 1 0 01-1.414-1.414L8.586 10 4.293 5.707a1 1 0 010-1.414z"
                  clip-rule="evenodd"
                ></path>
              </svg>
              <span class="sr-only">Close modal</span>
            </button>
          </div>
          <form enctype=“multipart/form-data”>
            <div class="grid gap-4 mb-4 sm:grid-cols-2">
              <div class="sm:col-span-2">
                  <label
                    for="name"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Title</label
                  >
                  <input
                  id="title"
                  name="title"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter Title"
                    required=""
                  />
                </div>

              <div class="sm:col-span-2">
                  <label
                    for="description"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Description</label
                  >
                  <textarea
                  id="description"
                  name="description"
                    rows="2"
                    class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Write description here"
                  ></textarea>
                </div>

              <div class="sm:col-span-2">
                <label
                  class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                  >Content</label
                >
                <input
                  class="block w-full text-sm text-gray-900 border border-gray-300 rounded-lg cursor-pointer bg-gray-50 dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400"                    
                  id="content"
                  name="content"
                  type="file"
                />
              </div>
              <div class="sm:col-span-2">
                <label
                  class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                  >Order</label
                >
                <input
                  class="block w-full text-sm text-gray-900 border border-gray-300 rounded-lg cursor-pointer bg-gray-50 dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400"                    
                  id="order"
                  name="order"
                  type="number"
                />
              </div>
            </div>
            <button
              @click.prevent="createData"
              type="submit"
              class="text-white inline-flex items-center bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800"
            >
              <svg
                class="mr-1 -ml-1 w-6 h-6"
                fill="currentColor"
                viewBox="0 0 20 20"
                xmlns="http://www.w3.org/2000/svg"
              >
                <path
                  fill-rule="evenodd"
                  d="M10 5a1 1 0 011 1v3h3a1 1 0 110 2h-3v3a1 1 0 11-2 0v-3H6a1 1 0 110-2h3V6a1 1 0 011-1z"
                  clip-rule="evenodd"
                ></path>
              </svg>
              Save
            </button>
          </form>
        </div>
      </div>
    </div>
    <div class="relative overflow-x-auto shadow-md">
  <table
    class="w-full text-sm text-left rtl:text-right text-gray-500 dark:text-gray-400"
  >
    <thead
      class="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400"
    >
      <tr>
        <th scope="col" class="px-6 py-3">Title</th>
        <th scope="col" class="px-6 py-3">Description</th>
        <th scope="col" class="px-6 py-3">Icon</th>
        <th scope="col" class="px-6 py-3">Order</th>
        <th scope="col" class="px-6 py-3">Actions</th>
       
      </tr>
    </thead>
    <tbody>
      <tr
        v-for="item in state.list"
        :key="item.id"
        class="bg-white border-b dark:bg-gray-800 dark:border-gray-700 border-gray-200 hover:bg-gray-50 dark:hover:bg-gray-600"
      >
       
        <td class="px-6 py-4">{{ item.title }}</td>        
        <td class="px-6 py-4">{{ item.description }}</td>      
        <td class="px-6 py-4">   <img class="w-10 h-10 rounded-full" :src="baseUrl + '/api/attachment/get/'+item.icon+''" alt=""></td>     
       
        <td class="px-6 py-4">{{ item.order }}</td>     
        <td class="px-6 py-4">
         
          <button
            @click="itemDelete(item.id)"
            class="ml-2 text-red-700 hover:text-white border border-red-700 hover:bg-red-800 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded-lg text-sm px-3 py-1 text-center me-2 mb-2 dark:border-red-500 dark:text-red-500 dark:hover:text-white dark:hover:bg-red-600 dark:focus:ring-red-900"
            >Delete</button
          >
        </td>
      </tr>
    </tbody>
  </table>
</div>
  </div>
</template>
<script setup>
definePageMeta({
layout: "admin",
middleware: ['auth']
});

import { onMounted } from "vue";
import { useFlowbite } from "~/composables/useFlowbite";
import { toast } from 'vue3-toastify';
import 'vue3-toastify/dist/index.css';


const runtimeConfig = useRuntimeConfig();
const baseUrl = runtimeConfig.public.baseURL
console.log(baseUrl);


// initialize components based on data attribute selectors
onMounted(() => {
useFlowbite((flowbite) => {
  initFlowbite();
});
});


const state = reactive({
list: [],
});

nextTick(async () => {
var projectId=document.getElementById('projectId').value
console.log(projectId)
const { data } = await useUserAPI("/api/project/getfeature?projectId="+projectId+"", {
  method: "GET",
});
state.list = data.value;
});

const createData = async  () => {
var formData = new FormData()
var content = document.getElementById('content').files[0]
var title = document.getElementById('title').value
var description = document.getElementById('description').value
var projectId=document.getElementById('projectId').value
var order = document.getElementById('order').value

formData.append('icon', content)
formData.append('title', title)
formData.append('description', description)
formData.append('projectId', projectId)
formData.append('order', order)
    

const { data } = await useUserAPI("/api/project/featurecreate", {
  method: "POST",
  body: formData,
});
showToatSuccess(data.value);
location.reload(); 
}


const itemDelete=async(id)=>{    
const { data } = await useUserAPI("/api/project/featuredelete?id="+id+"", {
  method: "POST",
});
showToatSuccess(data.value);
location.reload(); 
}
const itemActiveInactive=async(id,value)=>{
  const { data } = await useUserAPI("/api/project/featureactiveinactive?id="+id+"&value="+value+"", {
  method: "POST",
});
showToatSuccess(data.value);
location.reload(); 
}

const  showToatSuccess=(message)=>{
            toast.success(message, {
        position: 'top-right',
        duration: 5000, // Toast duration in milliseconds
        dismissible: true, // Allow users to manually dismiss the toast
      }); 
    }
</script>