<template>
    <div class="px-5 pt-2">
        <div class="flex items-center mb-2">
      <h6 class="text-15 grow font-bold">Edit</h6>
      <div class="shrink-0">
        <NuxtLink
          to="/admin/project"
          class="px-5 py-1 text-white btn bg-cyan-600 border-cyan-500 hover:text-white hover:bg-cyan-600 hover:border-cyan-600 focus:text-white focus:bg-cyan-600 focus:border-cyan-600 focus:ring focus:ring-cyan-100 active:text-white active:bg-cyan-600 active:border-cyan-600 active:ring active:ring-cyan-100 dark:ring-cyan-400/20"
        >
          <span class="align-middle">Back</span>
        </NuxtLink>
      </div>
      </div>
        <form action="#" @submit.prevent="handleEditSubmit">
              <div class="grid gap-4 mb-4">
                <div class="sm:col-span-2">
                  <label
                    for="name"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Name</label
                  >
                  <input
                  v-model="project.name"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Type product name"
                    required=""
                  />
                </div>

                <div class="sm:col-span-2">
                  <label
                    for="Type"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Type</label
                  >
                  <select
                  v-model="project.type"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  >
                    <option selected>Select type</option>
                    <option value="Ongoing">Ongoing</option>
                    <option value="Upcoming">Upcoming</option>
                    <option value="Complete">Complete</option>
                  </select>
                </div>
                <div class="sm:col-span-2">
                  <label
                    for="description"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Description</label
                  >
                  <textarea
                   v-model="project.description"
                    rows="4"
                    class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Write product description here"
                  ></textarea>
                </div>
              </div>
              <button
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
</template>
<script>
definePageMeta({
  layout: 'admin',
  middleware: ['auth'],
});
import { ref, onMounted, nextTick } from 'vue';
import { useRoute } from 'vue-router';
import { useUserAPI } from '~/composables/useUserAPI';

const route = useRoute();

const projectId = ref('');
const project = ref({});
const isLoading = ref(false);
const isLoadingTitle = ref('Loading');
const errorList = ref({});

// Called on mount
onMounted(() => {
  projectId.value = route.params.id;
  getProject(projectId.value);
  handleEditSubmit();
});

function getProject(id) {
  nextTick(async () => {
    const { data } = await useUserAPI(`/api/project/getproject?projectId=${id}`, {
      method: 'GET',
    });
    project.value = data.value;
    console.log(project.value);
  });
}

async function handleEditSubmit() {
  isLoading.value = true;
  isLoadingTitle.value = 'Updating';

  const res = await useUserAPI('/api/project/edit', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      Accept: 'application/json',
    },
    body: {
      id: project.value.id,
      name: project.value.name,
      type: project.value.type,
      description: project.value.description,
    },
  });

  alert(res.data.value);
  isLoading.value = false;
}
</script>