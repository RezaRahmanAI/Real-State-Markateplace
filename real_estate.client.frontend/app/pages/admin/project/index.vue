<template>
  <div>
    <div class="flex items-center mb-2">
      <h6 class="text-15 grow font-bold">List of Projects</h6>
      <div class="shrink-0">
        <button
          id="defaultModalButton"
          data-modal-toggle="defaultModal"
          data-modal-target="defaultModal"
          type="button"
          class="px-5 py-1 text-white btn bg-cyan-600 border-cyan-500 hover:text-white hover:bg-cyan-600 hover:border-cyan-600 focus:text-white focus:bg-cyan-600 focus:border-cyan-600 focus:ring focus:ring-cyan-100 active:text-white active:bg-cyan-600 active:border-cyan-600 active:ring active:ring-cyan-100 dark:ring-cyan-400/20"
        >
          <span class="align-middle">Create Project</span>
        </button>
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
                Add Project
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
                    >Name</label
                  >
                  <input
                  id="name"
                  name="name"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter Name"
                    required=""
                  />
                </div>
                <div>
                  <label
                    for="category"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Category</label
                  >
                  <select
                    id="category"
                    name="category"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  >
                    <option selected>Select category</option>
                    <option value="Ongoing">Ongoing</option>
                    <option value="Upcoming">Upcoming</option>
                    <option value="Completed">Completed</option>
                    <option value="Handover">Handover</option>
                  </select>
                </div>
              
                <div>
                  <label
                    for="type"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Type</label
                  >
                  <select
                    id="type"
                    name="type"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  >
                    <option selected>Select type</option>
                    <option value="Residential">Residential</option>
                    <option value="Commercial">Commercial</option>
                    <option value="Land">Land</option>
                  </select>
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
                    for="address"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Address</label
                  >
                  <textarea
                  id="address"
                  name="address"
                    rows="2"
                    class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Write address here"
                  ></textarea>
                </div>
                
                <div>
                  <label
                    for="landArea"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Land Area</label
                  >
                  <input
                  id="landArea"
                  name="landArea"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter land area"
                  />
                </div>
                <div>
                  <label
                    for="builtUpArea"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Built Up Area</label
                  >
                  <input
                  id="builtUpArea"
                  name="builtUpArea"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter built up area"
                  />
                </div>

                <div>
                  <label
                    for="height"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Height</label
                  >
                  <input
                  id="height"
                  name="height"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter height"
                  />
                </div>
                <div>
                  <label
                    for="numberOfApartments"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Number of Apartments</label
                  >
                  <input
                  id="numberOfApartments"
                  name="numberOfApartments"
                    type="number"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter number of apartments"
                  />
                </div>
                <div>
                  <label
                    for="numberOfParking"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Number of Parkings</label
                  >
                  <input
                  id="numberOfParking"
                  name="numberOfParking"
                    type="number"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter number of parking"
                  />
                </div>

                <div>
                  <label
                    for="unitPerFloors"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Unit Per Floors</label
                  >
                  <input
                  id="unitPerFloors"
                  name="unitPerFloors"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter unit per floors"
                  />
                </div>
                <div>
                  <label
                    for="sizeOfEachApartment"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Size of Each Apartment</label
                  >
                  <input
                  id="sizeOfEachApartment"
                  name="sizeOfEachApartment"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter size of each apartment"
                  />
                </div>

                <div>
                  <label
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    for="file_input"
                    >Thumbnail</label
                  >
                  <input
                    class="block w-full text-sm text-gray-900 border border-gray-300 rounded-lg cursor-pointer bg-gray-50 dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400"
                    aria-describedby="file_input_help"
                    id="thumbnail"
                    name="thumbnail"
                    type="file"
                  />
                  <p
                    class="mt-1 text-sm text-gray-500 dark:text-gray-300"
                    id="file_input_help"
                  >
                    SVG, PNG, JPG or GIF (MAX. 800x400px).
                  </p>
                </div>
                <div>
                  <label
                    for="contentType"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Content Type</label
                  >
                  <select
                    id="contentType"
                    name="contentType"
                    v-model="contentType"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  >
                    <option selected>Select content type</option>
                    <option value="Image">Image</option>
                    <option value="Video">Video</option>
                  </select>
                </div>

                <div>
                  <label
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >
                      {{ contentType === 'Video' ? 'Content (Video max 15MB)' : 'Content' }}
                    </label
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
                    for="postedDate"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Offer Date Time</label
                  >
                
                  <input
                  id="offerDateTime"
                  name="offerDateTime"
                    type="datetime-local"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder=""
                    required=""
                  />
                </div>
                <div class="sm:col-span-2">
                  <label
                    for="offerTile"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Offer Tile</label
                  >
                  <textarea
                  id="offerTile"
                  name="offerTile"
                    rows="2"
                    class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Write address here"
                  ></textarea>
                </div>
                <div class="hidden">
                  <label
                    for="latitude"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Latitude</label
                  >
                  <input
                  id="latitude"
                  name="latitude"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter map latitude"
                  />
                </div>
                <div class="hidden">
                  <label
                    for="longitude"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Longitude</label
                  >
                  <input
                  id="longitude"
                  name="longitude"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter map longitude"
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
        <div class="relative p-4 w-full max-w-2xl h-full">
          <div
            class="relative p-4 bg-white rounded-lg shadow dark:bg-gray-800 sm:p-5"
          >
            <div
              class="flex justify-between items-center pb-4 mb-4 rounded-t border-b sm:mb-5 dark:border-gray-600"
            >
              <h3 class="text-lg font-semibold text-gray-900 dark:text-white">
                Edit Project
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
                    for="name"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Name</label
                  >
                  <input
                  id="editname"
                  name="editname"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter Name"
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
                <div>
                  <label
                    for="category"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Category</label
                  >
                  <select
                    id="editcategory"
                    name="editcategory"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  >
                    <option selected>Select category</option>
                    <option value="Ongoing">Ongoing</option>
                    <option value="Upcoming">Upcoming</option>
                    <option value="Completed">Completed</option>
                    <option value="Handover">Handover</option>
                  </select>
                </div>
              
                <div>
                  <label
                    for="type"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Type</label
                  >
                  <select
                    id="edittype"
                    name="edittype"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  >
                    <option selected>Select type</option>
                    <option value="Residential">Residential</option>
                    <option value="Commercial">Commercial</option>
                    <option value="Land">Land</option>
                  </select>
                </div>
              
                <div class="sm:col-span-2">
                  <label
                    for="description"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Description</label
                  >
                  <textarea
                  id="editdescription"
                  name="editdescription"
                    rows="2"
                    class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Write description here"
                  ></textarea>
                </div>
                <div class="sm:col-span-2">
                  <label
                    for="address"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Address</label
                  >
                  <textarea
                  id="editaddress"
                  name="editaddress"
                    rows="2"
                    class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Write address here"
                  ></textarea>
                </div>
                
                <div>
                  <label
                    for="landArea"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Land Area</label
                  >
                  <input
                  id="editlandArea"
                  name="editlandArea"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter land area"
                  />
                </div>
                <div>
                  <label
                    for="builtUpArea"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Built Up Area</label
                  >
                  <input
                  id="editbuiltUpArea"
                  name="editbuiltUpArea"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter built up area"
                  />
                </div>

                <div>
                  <label
                    for="height"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Height</label
                  >
                  <input
                  id="editheight"
                  name="editheight"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter height"
                  />
                </div>
                <div>
                  <label
                    for="numberOfApartments"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Number of Apartments</label
                  >
                  <input
                  id="editnumberOfApartments"
                  name="editnumberOfApartments"
                    type="number"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter number of apartments"
                  />
                </div>
                <div>
                  <label
                    for="numberOfParking"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Number of Parkings</label
                  >
                  <input
                  id="editnumberOfParking"
                  name="editnumberOfParking"
                    type="number"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter number of parking"
                  />
                </div>

                <div>
                  <label
                    for="unitPerFloors"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Unit Per Floors</label
                  >
                  <input
                  id="editunitPerFloors"
                  name="editunitPerFloors"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter unit per floors"
                  />
                </div>
                <div>
                  <label
                    for="sizeOfEachApartment"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Size of Each Apartment</label
                  >
                  <input
                  id="editsizeOfEachApartment"
                  name="editsizeOfEachApartment"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter size of each apartment"
                  />
                </div>

                <div>
                  <label
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    for="file_input"
                    >Thumbnail</label
                  >
                  <input
                    class="block w-full text-sm text-gray-900 border border-gray-300 rounded-lg cursor-pointer bg-gray-50 dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400"
                    aria-describedby="file_input_help"
                    id="editthumbnail"
                    name="editthumbnail"
                    type="file"
                  />
                  <p
                    class="mt-1 text-sm text-gray-500 dark:text-gray-300"
                    id="file_input_help"
                  >
                    SVG, PNG, JPG or GIF (MAX. 800x400px).
                  </p>
                </div>
                <div>
                  <label
                    for="contentType"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Content Type</label
                  >
                  <select
                    id="editcontentType"
                    name="editcontentType"
                    v-model="contentType"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                  >
                    <option selected>Select content type</option>
                    <option value="Image">Image</option>
                    <option value="Video">Video</option>
                  </select>
                </div>

                <div>
                  <label
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >
                      {{ contentType === 'Video' ? 'Content (Video max 15MB)' : 'Content' }}
                    </label
                  >
                  <input
                    class="block w-full text-sm text-gray-900 border border-gray-300 rounded-lg cursor-pointer bg-gray-50 dark:text-gray-400 focus:outline-none dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400"                    
                    id="editcontent"
                    name="editcontent"
                    type="file"
                  />
                </div>
                <div class="sm:col-span-2">
                  <label
                    for="offerTile"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Offer Tile</label
                  >
                  <textarea
                  id="editofferTile"
                  name="editofferTile"
                    rows="2"
                    class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Write address here"
                  ></textarea>
                </div>
                <div class="sm:col-span-2">
                  <label
                    for="postedDate"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Offer Date Time</label
                  >
                
                  <input
                  id="editofferDateTime"
                  name="editofferDateTime"
                    type="datetime-local"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder=""
                    required=""
                  />
                </div>
                <div class="hidden">
                  <label
                    for="latitude"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Latitude</label
                  >
                  <input
                  id="editlatitude"
                  name="editlatitude"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter map latitude"
                  />
                </div>
                <div class="hidden">
                  <label
                    for="longitude"
                    class="block mb-2 text-sm font-medium text-gray-900 dark:text-white"
                    >Longitude</label
                  >
                  <input
                  id="editlongitude"
                  name="editlongitude"
                    type="text"
                    class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-600 focus:border-blue-600 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                    placeholder="Enter map longitude"
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
          <th scope="col" class="px-6 py-3">Name</th>
          <th scope="col" class="px-6 py-3">Description</th>
          <th scope="col" class="px-6 py-3">Address</th>
          <th scope="col" class="px-6 py-3">Thumbnail</th>
          <th scope="col" class="px-6 py-3">Category</th>
          <th scope="col" class="px-6 py-3">Type</th>
          <th scope="col" class="px-6 py-3">Content</th>
          <th scope="col" class="px-6 py-3">Offer Title</th>
          <th scope="col" class="px-6 py-3">Offer Date</th>
          <th scope="col" class="px-6 py-3">Status</th>
          <th scope="col" class="px-6 py-3">Actions</th>
         
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
            {{ item.name }}
          </th>
          <td class="px-6 py-4">{{ item.description }}</td>
          <td class="px-6 py-4">{{ item.address }}</td>
          <td class="px-6 py-4">
            <img class="w-16 h-10" :src="baseUrl + '/api/attachment/get/'+item.thumbnail+''" alt="">
          </td>
          <td class="px-6 py-4">{{ item.category }}</td>
          <td class="px-6 py-4">{{ item.type }}</td>
          <td class="px-6 py-4" >
            <span v-if="item.contentType=='Image'">
              <img class="w-16 h-10" :src="baseUrl + '/api/attachment/get/'+item.content+''" alt="">
            </span>
            <span v-else-if="item.contentType=='Video'">
              <video class="w-16 h-10" controls>
                <source :src="baseUrl + '/api/attachment/get/'+item.content+''" type="video/mp4" />
              </video>
            </span>
          </td>
          <td class="px-6 py-4">{{ item.offerTile }}</td>
          <td class="px-6 py-4">{{ item.offerDateTime }}</td>
          <td class="px-6 py-4" >
            <span v-if="item.isActive">
              <span class="px-2.5 py-0.5 text-xs font-medium rounded border bg-green-100 border-transparent text-green-500 dark:bg-green-500/20 dark:border-transparent inline-flex items-center status\"><i class="ri-checkbox-line text-green-500 mr-1.5"></i>  Active </span>
            </span>
            <span v-else-if="item.isActive==false">
              <span class="px-2.5 py-0.5 inline-flex items-center text-xs font-medium rounded border bg-red-100 border-transparent text-red-500 dark:bg-red-500/20 dark:border-transparent status\"><i class="ri-close-circle-line text-red-400 mr-1.5"></i>  Inactive </span>
            </span>


          </td>
          <td class="px-6 py-4 text-right">
            <button
             @click="showEditModal(item.id,item.name,item.description, item.address,item.landArea,item.builtUpArea,item.height,item.numberOfApartments,item.numberOfParking,item.unitPerFloors, item.sizeOfEachApartment, item.category,item.type,item.latitude,item.longitude,item.contentType)"
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
            <NuxtLink
              :to="'/admin/project/gallery' + item.id + ''"
              class="ml-2 text-blue-700 hover:text-white border border-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-3 py-1 text-center me-2 mb-2 dark:border-blue-500 dark:text-blue-500 dark:hover:text-white dark:hover:bg-blue-600 dark:focus:ring-blue-900"
              >Gallery</NuxtLink
              
            >
            <NuxtLink
              :to="'/admin/project/feature' + item.id + ''"
              class="ml-2 text-blue-700 hover:text-white border border-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-3 py-1 text-center me-2 mb-2 dark:border-blue-500 dark:text-blue-500 dark:hover:text-white dark:hover:bg-blue-600 dark:focus:ring-blue-900"
              >Features</NuxtLink
              
            >
            <!-- <NuxtLink
              :to="{ name: '/admin/project/gallery', params: { id: item.id } }"
              class="ml-2 text-blue-700 hover:text-white border border-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-3 py-1 text-center me-2 mb-2 dark:border-blue-500 dark:text-blue-500 dark:hover:text-white dark:hover:bg-blue-600 dark:focus:ring-blue-900"
              >Gallery</NuxtLink
              
            > -->
            <!-- <router-link :to="{ name: '/admin/project/gallery', params: { id: item.id }}"></router-link> -->
          </td>
        </tr>
      </tbody>
    </table>
  </div>
  </div>
</template>

<script setup>
import { ref } from 'vue'
import { onMounted } from "vue";
import { useFlowbite } from "~/composables/useFlowbite";
import { toast } from 'vue3-toastify';
import 'vue3-toastify/dist/index.css';

definePageMeta({
  layout: "admin",
  middleware: ['auth'],
});

const contentType = ref('')

const runtimeConfig = useRuntimeConfig();
  const baseUrl = runtimeConfig.public.baseURL
  console.log(baseUrl);

  const state = reactive({
  list: [],
});

// initialize components based on data attribute selectors
onMounted(() => {


  nextTick(async () => {
  const { data } = await useUserAPI("/api/project", {
    method: "GET",
  });
  state.list = data.value;
  console.log(state.list);
});

  

  useFlowbite((flowbite) => {
    initFlowbite();
  });
});






const createData = async  () => {
  var formData = new FormData()
  var content = document.getElementById('content').files[0]
  var thumbnail = document.getElementById('thumbnail').files[0]
  var contentType = document.getElementById('contentType').value
  var name = document.getElementById('name').value
  var description = document.getElementById('description').value
  var address = document.getElementById('address').value
  var offerTile = document.getElementById('offerTile').value
  var landArea = document.getElementById('landArea').value
  var builtUpArea = document.getElementById('builtUpArea').value
  var height = document.getElementById('height').value
  var numberOfApartments = document.getElementById('numberOfApartments').value
  var numberOfParking = document.getElementById('numberOfParking').value
  var unitPerFloors = document.getElementById('unitPerFloors').value
  var sizeOfEachApartment = document.getElementById('sizeOfEachApartment').value
  var category = document.getElementById('category').value
  var type = document.getElementById('type').value
  var latitude = document.getElementById('latitude').value
  var longitude = document.getElementById('longitude').value
  var offerDateTime = document.getElementById('offerDateTime').value
  console.log(offerDateTime);

  formData.append('content', content)
  formData.append('thumbnail', thumbnail)
  formData.append('contentType', contentType)
  formData.append('name', name)
  formData.append('description', description)
  formData.append('address', address)
  formData.append('offerTile', offerTile)
  formData.append('landArea', landArea)
  formData.append('builtUpArea', builtUpArea)
  formData.append('height', height)
  formData.append('numberOfApartments', numberOfApartments)
  formData.append('numberOfParking', numberOfParking)
  formData.append('unitPerFloors', unitPerFloors)
  formData.append('sizeOfEachApartment', sizeOfEachApartment)
  formData.append('category', category)
  formData.append('type', type)
  formData.append('latitude', latitude)
  formData.append('longitude', longitude)
  formData.append('offerDateTime', offerDateTime)  
  console.log(offerDateTime);

  const { data } = await useUserAPI("/api/project/create", {
    method: "POST",
    body: formData,
  });
  console.log(data);
  showToatSuccess(data.value);
  location.reload(); 
  }


  const editData = async  () => {
  var formData = new FormData()
  var content = document.getElementById('editcontent').files[0]
  var thumbnail = document.getElementById('editthumbnail').files[0]
  var contentType = document.getElementById('editcontentType').value
  var name = document.getElementById('editname').value
  var description = document.getElementById('editdescription').value
  var address = document.getElementById('editaddress').value
  var offerTile = document.getElementById('editofferTile').value
  var landArea = document.getElementById('editlandArea').value
  var builtUpArea = document.getElementById('editbuiltUpArea').value
  var height = document.getElementById('editheight').value
  var numberOfApartments = document.getElementById('editnumberOfApartments').value
  var numberOfParking = document.getElementById('editnumberOfParking').value
  var unitPerFloors = document.getElementById('editunitPerFloors').value
  var sizeOfEachApartment = document.getElementById('editsizeOfEachApartment').value
  var category = document.getElementById('editcategory').value
  var type = document.getElementById('edittype').value
  var latitude = document.getElementById('editlatitude').value
  var longitude = document.getElementById('editlongitude').value
  var id = document.getElementById('editid').value
  var offerDateTime = document.getElementById('editofferDateTime').value

  formData.append('content', content)
  formData.append('thumbnail', thumbnail)
  formData.append('contentType', contentType)
  formData.append('name', name)
  formData.append('description', description)
  formData.append('address', address)
  formData.append('offerTile', offerTile)
  formData.append('landArea', landArea)
  formData.append('builtUpArea', builtUpArea)
  formData.append('height', height)
  formData.append('numberOfApartments', numberOfApartments)
  formData.append('numberOfParking', numberOfParking)
  formData.append('unitPerFloors', unitPerFloors)
  formData.append('sizeOfEachApartment', sizeOfEachApartment)
  formData.append('category', category)
  formData.append('type', type)
  formData.append('latitude', latitude)
  formData.append('longitude', longitude)
  formData.append('id', id)
  formData.append('offerDateTime', offerDateTime)
  console.log(offerDateTime);
      

  const { data } = await useUserAPI("/api/project/edit", {
    method: "POST",
    body: formData,
  });
  console.log(data);
  hideEditModal();
  showToatSuccess(data.value);
  location.reload(); 
  }
  
  const itemDelete=async(id)=>{    
  const { data } = await useUserAPI("/api/project/delete?id="+id+"", {
    method: "POST",
  });
  showToatSuccess(data.value);
  location.reload(); 
  }
  const itemActiveInactive=async(id,value)=>{
    const { data } = await useUserAPI("/api/project/itemactiveinactive?id="+id+"&value="+value+"", {
    method: "POST",
  });
  showToatSuccess(data.value);
  location.reload(); 
}

const showEditModal=async(id,name,description, address,landArea,builtUpArea,height,numberOfApartments,numberOfParking,unitPerFloors, sizeOfEachApartment, category,type,latitude,longitude,contentType, offerDateTime)=>{
    const $modal= document.querySelector('#editModal');
    const modal = new Modal($modal);
    modal.toggle();
    document.getElementById("editid").value=id
    document.getElementById("editdescription").value=description
    document.getElementById('editname').value=name
    document.getElementById('editaddress').value=address
    document.getElementById('editlandArea').value=landArea
    document.getElementById('editbuiltUpArea').value=builtUpArea
    document.getElementById('editheight').value=height
    document.getElementById('editnumberOfApartments').value=numberOfApartments
    document.getElementById('editnumberOfParking').value=numberOfParking
    document.getElementById('editunitPerFloors').value=unitPerFloors
    document.getElementById('editsizeOfEachApartment').value=sizeOfEachApartment
    document.getElementById('editcategory').value=category
    document.getElementById('edittype').value=type
    document.getElementById('editlatitude').value=latitude
    document.getElementById('editlongitude').value=longitude
    document.getElementById('editcontentType').value=contentType
    document.getElementById('editofferDateTime').value = offerDateTime
    
    
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
