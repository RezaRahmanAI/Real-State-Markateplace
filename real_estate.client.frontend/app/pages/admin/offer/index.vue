<template>
  <div>
    <div class="flex items-center mb-2">
      <h6 class="text-15 grow font-bold">List of Offers</h6>
      <div class="shrink-0">
        <button
         v-if="!state.list || state.list.length === 0"
          id="defaultModalButton"
          data-modal-toggle="defaultModal"
          data-modal-target="defaultModal"
          type="button"
          class="px-5 py-1 text-white btn bg-cyan-600 border-cyan-500 hover:text-white hover:bg-cyan-600 hover:border-cyan-600 focus:text-white focus:bg-cyan-600 focus:border-cyan-600 focus:ring focus:ring-cyan-100 active:text-white active:bg-cyan-600 active:border-cyan-600 active:ring active:ring-cyan-100 dark:ring-cyan-400/20"
        >
          <span class="align-middle">Create Offer</span>
        </button>
      </div>

      <div
        id="defaultModal"
        tabindex="-1"
        aria-hidden="true"
        class="hidden overflow-y-auto overflow-x-hidden fixed top-0 right-0 left-0 z-50 justify-center items-center w-full md:inset-0 h-[calc(100%-1rem)] max-h-full"
      >
        <div class="relative p-4 w-full max-w-2xl h-full md:h-auto">
          <div
            class="relative p-4 bg-white rounded-lg shadow dark:bg-gray-800 sm:p-5"
          >
            <div
              class="flex justify-between items-center pb-4 mb-4 rounded-t border-b sm:mb-5 dark:border-gray-600"
            >
              <h3 class="text-lg font-semibold text-gray-900 dark:text-white">
                Add Offer
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
                    for="title"
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

                <div class="sm:col-span-2 hidden">
                  <label
                    for="Description"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Description</label
                  >
                  <textarea
                  id="description"
                  name="description"
                    rows="4"
                    class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Write description here"
                  ></textarea>
                </div>
                <div class="sm:col-span-2">
                  <label
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    for="file_input"
                    >Image</label
                  >
                  <input
                    class="block w-full text-sm text-gray-900 border border-gray-300 rounded-lg cursor-pointer bg-gray-50 dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400"
                    aria-describedby="file_input_help"
                    id="image"
                    name="image"
                    type="file"
                  />              
                </div>

                <div class="sm:col-span-2">
                  <label
                    for="StartDate"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Start Date</label
                  >
                  <input
                  id="startDate"
                  name="startDate"
                    type="Date"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder=""
                    required=""
                  />
                </div>
                <div class="sm:col-span-2">
                  <label
                    for="EndDate"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >End Date</label
                  >
                  <input
                  id="endDate"
                  name="endDate"
                    type="Date"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder=""
                    required=""
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
      <div id="editModal"
        tabindex="-1"
        aria-hidden="true"
        class="hidden overflow-y-auto overflow-x-hidden fixed top-0 right-0 left-0 z-50 justify-center items-center w-full md:inset-0 h-[calc(100%-1rem)] max-h-full"
      >
        <div class="relative p-4 w-full max-w-2xl h-full md:h-auto">
          <div
            class="relative p-4 bg-white rounded-lg shadow dark:bg-gray-800 sm:p-5"
          >
            <div
              class="flex justify-between items-center pb-4 mb-4 rounded-t border-b sm:mb-5 dark:border-gray-600"
            >
              <h3 class="text-lg font-semibold text-gray-900 dark:text-white">
                Edit Offer
              </h3>
              <button
                type="button"
                class="text-gray-400 bg-transparent hover:bg-gray-200 hover:text-gray-900 rounded-lg text-sm p-1.5 ml-auto inline-flex items-center dark:hover:bg-gray-600 dark:hover:text-white"
                     @click="hideEditModal()"
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
                    for="title"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Title</label
                  >
                  <input
                  id="edittitle"
                  name="edittitle"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter Title"
                    required=""
                  />

                  <input
                  id="editid"
                  name="editid"
                    type="text"
                    class="hidden"
                    placeholder="Enter Id"
                    required="" 
                  />
                </div>

                <div class="sm:col-span-2 hidden">
                  <label
                    for="Description"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Description</label
                  >
                  <textarea
                  id="editdescription"
                  name="editdescription"
                    rows="4"
                    class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Write description here"
                  ></textarea>
                </div>
                <div class="sm:col-span-2">
                  <label
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    for="file_input"
                    >Image</label
                  >
                  <input
                    class="block w-full text-sm text-gray-900 border border-gray-300 rounded-lg cursor-pointer bg-gray-50 dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400"
                    aria-describedby="file_input_help"
                    id="editimage"
                    name="editimage"
                    type="file"
                  />
                 
                </div>
                
                <div class="sm:col-span-2">
                  <label
                    for="StartDate"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Start Date</label
                  >
                  <input
                  id="editstartDate"
                  name="editstartDate"
                    type="Date"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder=""
                    required=""
                  />
                </div>
                <div class="sm:col-span-2">
                  <label
                    for="EndDate"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >End Date</label
                  >
                  <input
                  id="editendDate"
                  name="editendDate"
                    type="Date"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder=""
                    required=""
                  />
                </div>
              </div>
              <button
                @click.prevent="editData"
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
                Update
              </button>
            </form>
          </div>
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
          <th scope="col" class="px-6 py-3 hidden">Description</th>
          <th scope="col" class="px-6 py-3">Image</th>
          <th scope="col" class="px-6 py-3">Status</th>
          <th scope="col" class="px-6 py-3">Start Date</th>
          <th scope="col" class="px-6 py-3">End Date</th>
          <th scope="col" class="px-6 py-3">Action</th>
        
        </tr>
      </thead>
      <tbody>
        <tr
          v-for="item in state.list"
          :key="item.id"
          class="bg-white border-b dark:bg-gray-800 dark:border-gray-700 border-gray-200 hover:bg-gray-50 dark:hover:bg-gray-600"
        >
          <th
            scope="row"
            class="px-6 py-4 font-medium text-gray-900 whitespace-nowrap dark:text-white"
          >
            {{ item.title }}
          </th>
          <td class="px-6 py-4 hidden">{{ item.description }}</td>
          
          <td class="px-6 py-4"> <img class="w-16 h-10" :src="baseUrl + '/api/attachment/get/'+item.picture+''" alt=""></td>
                   
          <td class="px-6 py-4" >
            <span v-if="item.isActive">
              <span class="px-2.5 py-0.5 text-xs font-medium rounded border bg-green-100 border-transparent text-green-500 dark:bg-green-500/20 dark:border-transparent inline-flex items-center status\"><i class="ri-checkbox-line text-green-500 mr-1.5"></i>  Active </span>
            </span>
            <span v-else-if="item.isActive==false">
              <span class="px-2.5 py-0.5 inline-flex items-center text-xs font-medium rounded border bg-red-100 border-transparent text-red-500 dark:bg-red-500/20 dark:border-transparent status\"><i class="ri-close-circle-line text-red-400 mr-1.5"></i>  Inactive </span>
            </span>
          </td>
          <td class="px-6 py-4">{{ item.startDate }}</td>
          <td class="px-6 py-4">{{ item.endDate }}</td>
          <td class="px-6 py-4 text-right">
            <button
             @click="showEditModal(item.id,item.title,item.description,item.startDate, item.endDate)"
              class="text-blue-700 hover:text-white border border-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-3 py-1 text-center me-2 mb-2 dark:border-blue-500 dark:text-blue-500 dark:hover:text-white dark:hover:bg-blue-500 dark:focus:ring-blue-800"
              >Edit</button
            >
            <span v-if="item.isActive">
              <button
              @click="itemActiveInactive(item.id,false)"
              class=" ml-2 text-red-700 hover:text-white border border-red-700 hover:bg-red-800 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded-lg text-sm px-3 py-1 text-center me-2 mb-2 dark:border-red-500 dark:text-red-500 dark:hover:text-white dark:hover:bg-red-600 dark:focus:ring-red-900"
              >Deactive</button
            >
            </span>
            <span v-else-if="item.isActive==false">
              <button
              @click="itemActiveInactive(item.id,true)"
              class="ml-2 text-green-700 hover:text-white border border-green-700 hover:bg-green-800 focus:ring-4 focus:outline-none focus:ring-green-300 font-medium rounded-lg text-sm px-3 py-1 text-center me-2 mb-2 dark:border-green-500 dark:text-green-500 dark:hover:text-white dark:hover:bg-green-600 dark:focus:ring-green-800"
              >Active</button
            >
            </span>
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
const state = reactive({
  list: [],
});
onMounted(() => {
  nextTick(async () => {
  const { data } = await useUserAPI("/api/offer", {
    method: "GET",
  });
  state.list = data.value;
});
  useFlowbite((flowbite) => {
    initFlowbite();
  });
});






const createData = async  () => {
  var formData = new FormData()
  var image = document.getElementById('image').files[0]
  var title = document.getElementById('title').value
  var description = document.getElementById('description').value
  var startDate = document.getElementById('startDate').value
  var endDate = document.getElementById('endDate').value
  formData.append('image', image)
  formData.append('title', title)
  formData.append('description', description)
  formData.append('startDate', startDate)    
  formData.append('endDate', endDate)   

  const { data } = await useUserAPI("/api/offer/create", {
    method: "POST",
    body: formData,
  });
  console.log(data);
  showToatSuccess(data.value);
  location.reload(); 
  }


  const editData = async  () => {
  var formData = new FormData()
  var image = document.getElementById('editimage').files[0]
  var title = document.getElementById('edittitle').value
  var description = document.getElementById('editdescription').value
  var startDate = document.getElementById('editstartDate').value
  var endDate = document.getElementById('editendDate').value
  var id = document.getElementById('editid').value
  formData.append('image', image)
  formData.append('title', title)
  formData.append('description', description)
  formData.append('startDate', startDate)
  formData.append('endDate', endDate)
  formData.append('id', id)
      

  const { data } = await useUserAPI("/api/offer/edit", {
    method: "POST",
    body: formData,
  });
  console.log(data);
  hideEditModal();
  showToatSuccess(data.value);
  location.reload(); 
  }
  
  const itemDelete=async(id)=>{    
  const { data } = await useUserAPI("/api/offer/delete?id="+id+"", {
    method: "POST",
  });
  showToatSuccess(data.value);
  location.reload(); 
  }
  const itemActiveInactive=async(id,value)=>{
    console.log(id);
    console.log(value);
    const { data } = await useUserAPI("/api/offer/itemactiveinactive?id="+id+"&value="+value+"", {
    method: "POST",
  });
  showToatSuccess(data.value);
  location.reload(); 
}

const showEditModal=async(id,title,description,startDate, endDate)=>{
    const $modal= document.querySelector('#editModal');
    const modal = new Modal($modal);
    modal.toggle();
    document.getElementById("editid").value=id
    document.getElementById("edittitle").value=title
    document.getElementById("editdescription").value=description
    document.getElementById("editstartDate").value=startDate
    document.getElementById("editendDate").value=endDate
    
}

const hideEditModal=async()=>{
  const $modal= document.querySelector('#editModal');
  const modal = new Modal($modal);
  modal.hide();   
}

const  showToatSuccess=(message)=>{
            toast.success(message, {
        position: 'top-right',
        duration: 5000, // Toast duration in milliseconds
        dismissible: true, // Allow users to manually dismiss the toast
      }); 
    }
</script>


<style></style>
