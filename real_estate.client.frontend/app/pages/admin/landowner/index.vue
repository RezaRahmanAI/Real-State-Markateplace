<template>
  <div>
    <div class="flex items-center mb-2">
      <h6 class="text-15 grow font-bold">List of Landowners</h6>
    </div>
    <div class="relative overflow-x-auto shadow-md">
      <table
        class="w-full text-sm text-left rtl:text-right text-gray-500 dark:text-gray-400"
      >
        <thead
          class="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400"
        >
          <tr>
            <th scope="col" class="px-6 py-3">Name</th>
            <th scope="col" class="px-6 py-3">Phone</th>
            <th scope="col" class="px-6 py-3">Email</th>
            <th scope="col" class="px-6 py-3">Contact Person</th>
            <th scope="col" class="px-6 py-3">Message</th>
            <th scope="col" class="px-6 py-3">Address</th>
            <th scope="col" class="px-6 py-3">Locality</th>
            <th scope="col" class="px-6 py-3">Front Road Width</th>
            <th scope="col" class="px-6 py-3">Land Category</th>
            <th scope="col" class="px-6 py-3">Facing</th>
            <th scope="col" class="px-6 py-3">Attractive Benefits</th>
            <th scope="col" class="px-6 py-3">Date</th>
          </tr>
        </thead>
        <tbody>
          <tr
            v-for="item in state.list"
            :key="item.id"
            class="bg-white border-b dark:bg-gray-800 dark:border-gray-700 border-gray-200 hover:bg-gray-50 dark:hover:bg-gray-600"
          >
            <td class="px-6 py-4">{{ item.name }}</td>
            <td class="px-6 py-4">{{ item.phone }}</td>
            <td class="px-6 py-4">{{ item.email }}</td>
            <td class="px-6 py-4">{{ item.contactPerson }}</td>
            <td class="px-6 py-4">{{ item.message }}</td>
            <td class="px-6 py-4">{{ item.address }}</td>
            <td class="px-6 py-4">{{ item.locality }}</td>
            <td class="px-6 py-4">{{ item.frontRoadWidth }}</td>
            <td class="px-6 py-4">{{ item.landCategory }}</td>
            <td class="px-6 py-4">{{ item.facing }}</td>
            <td class="px-6 py-4">{{ item.attractiveBenefits }}</td>
            <td class="px-6 py-4">{{ item.createDate }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script setup>
definePageMeta({
  layout: "admin",
  middleware: ["auth"],
});

import { onMounted } from "vue";
import { useFlowbite } from "~/composables/useFlowbite";
// initialize components based on data attribute selectors
const state = reactive({
  list: [],
});
onMounted(() => {
  nextTick(async () => {
  const { data } = await useUserAPI("/api/landowner", {
    method: "GET",
  });
  state.list = data.value;
});
  useFlowbite((flowbite) => {
    initFlowbite();
  });
});




</script>

<style></style>
