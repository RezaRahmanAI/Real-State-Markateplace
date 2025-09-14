<template>
  <div>
    <input
      class="hidden"
      type="text"
      id="projectId"
      name="projectId"
      :value="$route.params.id"
    />
    <div class="headering py-36 sm:py-48 md:py-64 lg:py-72 xl:py-[400px]"></div>
    <div
      class="page_title absolute top-1/4 sm:top-1/3 md:top-2/4 lg:top-2/3 xl:top-3/4 2xl:top-[80%] left-0"
    >
      <h1 class="text-2xl sm:text-3xl md:text-4xl text-slate-100 p-5">
        / Project Details
      </h1>
    </div>

    <div
      class="offer_time_bar absolute top-24 sm:top-28 md:top-40 lg:top-1/4 xl:top-1/3 left-[0%] right-[0%]"
      v-if="state.offerActive"
    >
      <h2
        class="text-slate-200 text-2xl sm:text-3xl md:text-4xl xl:text-5xl font-bold text-center"
      >
        Offer Time
      </h2>
      <div class="mt-8 text-center" v-if="typeof state.timer !== 'string'">
        <span
          class="py-2 md:py-2.5 px-3.5 md:px-4 bg-slate-100 text-xl md:text-2xl lg:text-3xl xl:text-4xl font-bold text-blue-500 rounded me-3"
          >{{ state.timer.days }}</span
        >
        <span
          class="py-2 md:py-2.5 px-3.5 md:px-4 bg-slate-100 text-xl md:text-2xl lg:text-3xl xl:text-4xl font-bold text-blue-500 rounded me-3"
          >{{ state.timer.hours }}</span
        >
        <span
          class="py-2 md:py-2.5 px-3.5 md:px-4 bg-slate-100 text-xl md:text-2xl lg:text-3xl xl:text-4xl font-bold text-blue-500 rounded me-3"
          >{{ state.timer.minutes }}</span
        >
        <span
          class="py-2 md:py-2.5 px-3.5 md:px-4 bg-slate-100 text-xl md:text-2xl lg:text-3xl xl:text-4xl font-bold text-blue-500 rounded"
          >{{ state.timer.seconds }}</span
        >
      </div>
    </div>
    <input
      class="hidden"
      type="text"
      id="projectId"
      name="projectId"
      :value="$route.params.id"
    />

    <div class="container mx-auto">
      <div class="row">
        <div class="col-12">
          <div class="marquee bg-red-500 mt-5 rounded">
            <div class="text-track h1 mb-0 text-center">
              <span
                v-if="state.data != null && state.data.offerTile != null"
                class="text-2xl text-gray-100"
              >
                {{ state.data.offerTile }}
              </span>
            </div>
          </div>
        </div>
      </div>
    </div>

    <div class="tab_bar sticky top-10 z-20 hidden lg:block">
      <div class="container mx-auto">
        <div
          class="flex items-center gap-10 p-3 bg-gray-200 border border-slate-200 mt-10 shadow-inner rounded-md"
        >
          <a href="#atGlance">
            <p
              class="tab bg-blue-500 text-slate-50 py-3 px-6 rounded-lg hover:bg-blue-500 hover:text-slate-50 duration-500 ease-in-out"
            >
              At a Glance
            </p>
          </a>
          <a href="#featureAndAmenities">
            <p
              class="tab py-3 px-6 rounded-lg active:bg-slate-50 active:text-blue-500 hover:bg-blue-500 hover:text-slate-50 duration-500 ease-in-out"
            >
              Feature & Amenities
            </p>
          </a>
          <a href="#projectGallery">
            <p
              class="tab py-3 px-6 rounded-lg active:bg-slate-50 active:text-blue-500 hover:bg-blue-500 hover:text-slate-50 duration-500 ease-in-out"
            >
              Gallery
            </p>
          </a>
          <a href="#locationMap">
            <p
              class="tab py-3 px-6 rounded-lg active:bg-slate-50 active:text-blue-500 hover:bg-blue-500 hover:text-slate-50 duration-500 ease-in-out"
            >
              Location Map
            </p>
          </a>
          <a href="#relatedProjects">
            <p
              class="tab py-3 px-6 rounded-lg active:bg-slate-50 active:text-blue-500 hover:bg-blue-500 hover:text-slate-50 duration-500 ease-in-out"
            >
              Related Projects
            </p>
          </a>
          <a href="#contacting">
            <p
              class="tab py-3 px-6 rounded-lg active:bg-slate-50 active:text-blue-500 hover:bg-blue-500 hover:text-slate-50 duration-500 ease-in-out"
            >
              Contacting
            </p>
          </a>
        </div>
      </div>
    </div>

    <div class="project_details_section py-16" id="atGlance">
      <div class="lg:container mx-auto">
        <div class="md:flex md:flex-row mb-16">
          <div class="w-full md:w-[50%] p-4">
            <div class="projects_content">
              
              <div 
                v-if="state.data != null && state.data.contentType == 'Image'"
                class="porects_image mt-5"
                >
                <img
                  class="h-[400px] sm:h-[500px] md:h-[600px] lg:h-[600px] xl:h-[700px] 2xl:h-[800px] w-full rounded"
                  :src="
                    baseUrl + '/api/attachment/get/' + state.data.content + ''
                  "
                  alt=""
                />
              </div>
              <div 
                v-else-if="state.data != null && state.data.contentType == 'Video'"
                class="porects_video mt-5"
                >
                <video class="h-[300px] sm:h-full w-full rounded-lg" controls>
                  <source
                    :src="
                    baseUrl + '/api/attachment/get/' + state.data.content + ''
                  "
                    type="video/mp4"
                  />
                  Your browser does not support the video tag.
                </video>
              </div>
            </div>
          </div>
          <div class="w-full md:w-[50%] p-4">
            <div class="projects_text">
              <h1
                class="title text-4xl md:text-5xl lg:text-5xl xl:text-6xl text-slate-800 mb-10"
              >
                At a Glance
              </h1>
              <div class="porijecDetails">
                <table class="w-full">
                  <tbody>
                    <tr class="border-b border-gray-200">
                      <td class="py-4 px-2 w-36">
                        <strong>Address :</strong>
                      </td>
                      <td class="py-4 px-2">
                        <span
                          v-if="
                            state.data != null && state.data.address != null
                          "
                        >
                          {{ state.data.address }}</span
                        >
                        <span v-else> None</span>
                      </td>
                    </tr>
                    <tr class="border-b border-gray-200">
                      <td class="py-4 px-2 w-36">
                        <strong>Land Area :</strong>
                      </td>
                      <td class="py-4 px-2">
                        <span
                          v-if="
                            state.data != null && state.data.landArea != null
                          "
                        >
                          {{ state.data.landArea }}</span
                        >
                        <span v-else> None</span>
                      </td>
                    </tr>
                    <tr class="border-b border-gray-200">
                      <td class="py-4 px-2 w-36">
                        <strong>Height :</strong>
                      </td>
                      <td class="py-4 px-2">
                        <span
                          v-if="state.data != null && state.data.height != null"
                        >
                          {{ state.data.height }}</span
                        >
                        <span v-else> None</span>
                      </td>
                    </tr>
                    <tr class="border-b border-gray-200">
                      <td class="py-4 px-2 w-36">
                        <strong>Building Type :</strong>
                      </td>
                      <td class="py-4 px-2">
                        <span
                          v-if="state.data != null && state.data.type != null"
                        >
                          {{ state.data.type }}</span
                        >
                        <span v-else> None</span>
                      </td>
                    </tr>
                    <tr class="border-b border-gray-200">
                      <td class="py-4 px-2 w-36">
                        <strong>Number Of Apartments :</strong>
                      </td>
                      <td class="py-4 px-2">
                        <span
                          v-if="
                            state.data != null &&
                            state.data.numberOfApartments != null
                          "
                        >
                          {{ state.data.numberOfApartments }}</span
                        >
                        <span v-else> None</span>
                      </td>
                    </tr>
                    <tr class="border-b border-gray-200">
                      <td class="py-4 px-2 w-36">
                        <strong>Number Of Car Parking :</strong>
                      </td>
                      <td class="py-4 px-2">
                        <span
                          v-if="
                            state.data != null &&
                            state.data.numberOfParking != null
                          "
                        >
                          {{ state.data.numberOfParking }}</span
                        >
                        <span v-else> None</span>
                      </td>
                    </tr>
                    <tr class="border-b border-gray-200">
                      <td class="py-4 px-2 w-36">
                        <strong>Units Per Floor :</strong>
                      </td>
                      <td class="py-4 px-2">
                        <span
                          v-if="
                            state.data != null &&
                            state.data.unitPerFloors != null
                          "
                        >
                          {{ state.data.unitPerFloors }}</span
                        >
                        <span v-else> None</span>
                      </td>
                    </tr>
                    <tr class="border-b border-gray-200">
                      <td class="py-4 px-2 w-36">
                        <strong>Size Of Each Apartment :</strong>
                      </td>
                      <td class="py-4 px-2">
                        <span
                          v-if="
                            state.data != null &&
                            state.data.sizeOfEachApartment != null
                          "
                        >
                          {{ state.data.sizeOfEachApartment }}</span
                        >
                        <span v-else> None</span>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </div>
            </div>
          </div>
        </div>

        <div
          class="adds flex items-center justify-between w-4/5 sm:w-3/4 md:w-2/3 lg:w-2/4 xl:w-1/4 h-16 sm:h-20 p-3 bg-blue-500 ring-2 ring-offset-2 ring-blue-500 mx-auto rounded-full shadow-xl"
        >
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
            <!-- <span class="text-xl sm:text-2xl font-semibold text-slate-50">Get Start</span> -->
          </div>
          <div class="">
            <NuxtLink to="/Contact">
              <button
                class="bg-slate-50 text-sm sm:text-md px-5 py-2.5 sm:py-4 text-blue-500 rounded-full font-semibold hover:bg-slate-100 duration-500 ease-in-out"
              >
                Booking Now
              </button>
            </NuxtLink>
          </div>
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
            <!-- <span class="text-xl sm:text-2xl font-semibold text-slate-50">Get Start</span> -->
          </div>
        </div>
      </div>
    </div>

    <div class="feature_and_amenities py-10 px-2" id="featureAndAmenities">
      <div class="container mx-auto">
        <h1
          class="text-center text-4xl md:text-5xl lg:text-5xl xl:text-6xl text-slate-800 mb-16"
        >
          Feature & Amenities
        </h1>
        <div
          class="grid grid-cols-2 md:grid-cols-3 lg:grid-cols-4 xl:grid-cols-5 gap-3 mb-16"
        >
          <div
            v-for="itemfeature in state.list"
            :key="itemfeature.id"
            class="featureCard border border-blue-500 px-4 py-4 sm:py-14 rounded-xl hover:shadow-xl hover:-translate-y-2 duration-500 ease-in-out"
          >
            <div
              class="cardIcon text-center mb-3 flex items-center justify-center"
            >
              <img
                class="w-2/6 rounded-t-2xl object-ceve"
                :src="baseUrl + '/api/attachment/get/' + itemfeature.icon + ''"
                alt=""
              />
            </div>
            <div class="cardText text-center">
              <span class="text-lg text-blue-950">{{ itemfeature.title }}</span>
            </div>
          </div>
        </div>

        <div
          class="adds flex items-center justify-between w-4/5 sm:w-3/4 md:w-2/3 lg:w-2/4 xl:w-1/4 h-16 sm:h-20 p-3 bg-blue-500 ring-2 ring-offset-2 ring-blue-500 mx-auto rounded-full shadow-xl"
        >
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
           
          </div>
          <div class="">
            <NuxtLink to="/Contact">
              <button
                class="bg-slate-50 text-sm sm:text-md px-5 py-2.5 sm:py-4 text-blue-500 rounded-full font-semibold hover:bg-slate-100 duration-500 ease-in-out"
              >
                Enroll Now
              </button>
            </NuxtLink>
          </div>
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
           
          </div>
        </div>
      </div>
    </div>

    <div class="project_gallary py-14" id="projectGallery">
      <div class="container mx-auto">
        <h1
          class="text-center text-4xl lg:text-5xl xl:text-6xl text-slate-800 mb-16"
        >
          Gallery
        </h1>
        <div class="mb-16">
          <div class="containerw">
            <div
              v-for="(image, index) in state.gallery"
              :key="index"
              class="item"
            >
              <a
                :href="baseUrl + '/api/attachment/get/' + image.content + ''"
                data-fancybox="gallery"
              >
                <!-- <img class="w-full h-full" :src="image.src" :alt="image.alt" /> -->
                <span v-if="image.contentType == 'Image'">
                  <img
                    class="w-full h-full"
                    :src="baseUrl + '/api/attachment/get/' + image.content + ''"
                    alt=""
                  />
                </span>
                <span v-else-if="image.contentType == 'Video'">
                  <video class="w-full h-full" controls>
                    <source
                      :src="
                        baseUrl + '/api/attachment/get/' + image.content + ''
                      "
                      type="video/mp4"
                    />
                  </video>
                </span>
              </a>
            </div>
          </div>
        </div>

        <div
          class="adds flex items-center justify-between w-4/5 sm:w-3/4 md:w-2/3 lg:w-2/4 xl:w-1/4 h-16 sm:h-20 p-3 bg-blue-500 ring-2 ring-offset-2 ring-blue-500 mx-auto rounded-full shadow-xl"
        >
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
            <!-- <span class="text-xl sm:text-2xl font-semibold text-slate-50">Get Start</span> -->
          </div>
          <div class="">
            <NuxtLink to="/Contact">
              <button
                class="bg-slate-50 text-sm sm:text-md px-5 py-2.5 sm:py-4 text-blue-500 rounded-full font-semibold hover:bg-slate-100 duration-500 ease-in-out"
              >
                Order Now
              </button>
            </NuxtLink>
          </div>
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
            <!-- <span class="text-xl sm:text-2xl font-semibold text-slate-50">Get Start</span> -->
          </div>
        </div>
      </div>
    </div>

    <div class="project_location py-14" id="locationMap">
      <div class="">
        <h1
          class="text-center text-4xl lg:text-5xl xl:text-6xl text-slate-800 mb-16"
        >
          Location
        </h1>
        <div class="w-full mb-16">
          <iframe
            v-if="
              state.data != null &&
              state.data.latitude != null &&
              state.data.longitude != null
            "
            :src="
              'https://www.google.com/maps?q=' +
              state.data.latitude +
              ',' +
              state.data.longitude +
              ''
            "
            width="100%"
            height="650"
            style="border: 0"
            allowfullscreen=""
            loading="lazy"
            referrerpolicy="no-referrer-when-downgrade"
          ></iframe>
        </div>

        <div
          class="adds flex items-center justify-between w-4/5 sm:w-3/4 md:w-2/3 lg:w-2/4 xl:w-1/4 h-16 sm:h-20 p-3 bg-blue-500 ring-2 ring-offset-2 ring-blue-500 mx-auto rounded-full shadow-xl"
        >
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
            <!-- <span class="text-xl sm:text-2xl font-semibold text-slate-50">Get Start</span> -->
          </div>
          <div class="">
            <NuxtLink to="/Contact">
              <button
                class="bg-slate-50 text-sm sm:text-md px-5 py-2.5 sm:py-4 text-blue-500 rounded-full font-semibold hover:bg-slate-100 duration-500 ease-in-out"
              >
                Register Now
              </button>
            </NuxtLink>
          </div>
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
            <!-- <span class="text-xl sm:text-2xl font-semibold text-slate-50">Get Start</span> -->
          </div>
        </div>
      </div>
    </div>

    <div class="related_projects py-14 px-2" id="relatedProjects">
      <div class="container mx-auto">
        <h1
          class="text-center text-4xl lg:text-5xl xl:text-6xl mb-16 text-slate-800"
        >
          Related Projects
        </h1>
        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-5 mb-16">
          <div
            v-for="proitem in state.projects"
            :key="proitem.id"
            class="project_card border rounded-2xl shadow-xl hover:-translate-y-2 hover:ring-1 hover:ring-offset-2 hover:ring-blue-500 duration-500 ease-in-out"
          >
            <NuxtLink :to="'/projectdetails/' + proitem.id + ''">
              <div class="project_card_img rounded-t-2xl overflow-hidden">
                <img
                  class="w-full h-[450px] md:h-[350px] lg:h-[380px] xl:h-[450px] rounded-t-2xl object-cever"
                  :src="
                    baseUrl + '/api/attachment/get/' + proitem.thumbnail + ''
                  "
                  alt=""
                />
              </div>
              <div class="project_card_details p-4 text-center">
                <h1 class="text-2xl font-bold mb-3 duration-500 ease-in-out">
                  {{ proitem.name }}
                </h1>
                <p
                  class="font-semibold text-gray-500 !flex items-center gap-2 justify-center"
                >
                  <span>{{ proitem.category }}</span>
                  <span class="w-3 h-3 text-sm bg-gray-500 rounded-full"></span>
                  <span>{{ proitem.type }}</span>
                </p>
              </div>
            </NuxtLink>
          </div>
        </div>

        <div
          class="adds flex items-center justify-between w-4/5 sm:w-3/4 md:w-2/3 lg:w-2/4 xl:w-1/4 h-16 sm:h-20 p-3 bg-blue-500 ring-2 ring-offset-2 ring-blue-500 mx-auto rounded-full shadow-xl"
        >
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
            <!-- <span class="text-xl sm:text-2xl font-semibold text-slate-50">Get Start</span> -->
          </div>
          <div class="">
            <NuxtLink to="/Contact">
              <button
                class="bg-slate-50 text-sm sm:text-md px-5 py-2.5 sm:py-4 text-blue-500 rounded-full font-semibold hover:bg-slate-100 duration-500 ease-in-out"
              >
                Booking Now
              </button>
            </NuxtLink>
          </div>
          <div class="px-4 flex items-center gap-3">
            <i
              class="ri-bookmark-3-fill text-2xl sm:text-3xl text-slate-50"
            ></i>
            <!-- <span class="text-xl sm:text-2xl font-semibold text-slate-50">Get Start</span> -->
          </div>
        </div>
      </div>
    </div>

    <div class="contact_form py-14 bg-slate-400" id="contacting">
      <div class="container mx-auto">
        <h1
          class="text-center text-6xl lg:text-5xl xl:text-6xl text-slate-800 mb-16"
        >
          Contact Us
        </h1>
        <div class="">
          <form class="max-w-md mx-auto">
            <div class="relative z-0 w-full mb-5 group">
              <input
                type="text"
                name="name"
                id="name"
                class="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none dark:text-white dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer"
                placeholder=" "
                required
              />
              <label
                for="name"
                class="peer-focus:font-medium absolute text-sm text-gray-100 duration-300 transform -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 rtl:peer-focus:left-auto peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6"
                >Full Name</label
              >
            </div>
            <div class="relative z-0 w-full mb-5 group">
              <input
                type="number"
                name="phone"
                id="phone"
                class="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none dark:text-white dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer"
                placeholder=" "
                required
              />
              <label
                for="phone"
                class="peer-focus:font-medium absolute text-sm text-gray-100 duration-300 transform -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6"
                >Phone Number</label
              >
            </div>
            <div class="relative z-0 w-full mb-5 group">
              <input
                type="email"
                name="email"
                id="email"
                class="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none dark:text-white dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer"
                placeholder=" "
                required
              />
              <label
                for="email"
                class="peer-focus:font-medium absolute text-sm text-gray-100 duration-300 transform -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6"
                >Email</label
              >
            </div>
            <div class="grid md:grid-cols-1 md:gap-6">
              <div class="relative z-0 w-full mb-5 group">
                <textarea
                  name="subject"
                  id="subject"
                  class="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none dark:text-white dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer"
                ></textarea>
                <label
                  for="subject"
                  class="peer-focus:font-medium absolute text-sm text-gray-100 duration-300 transform -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6"
                  >Subject</label
                >
              </div>
            </div>
            <div class="grid md:grid-cols-1 md:gap-6">
              <div class="relative z-0 w-full mb-5 group">
                <textarea
                  name="message"
                  id="message"
                  class="block py-2.5 px-0 w-full text-sm text-gray-900 bg-transparent border-0 border-b-2 border-gray-300 appearance-none dark:text-white dark:border-gray-600 dark:focus:border-blue-500 focus:outline-none focus:ring-0 focus:border-blue-600 peer"
                ></textarea>
                <label
                  for="message"
                  class="peer-focus:font-medium absolute text-sm text-gray-100 duration-300 transform -translate-y-6 scale-75 top-3 -z-10 origin-[0] peer-focus:start-0 rtl:peer-focus:translate-x-1/4 peer-focus:text-blue-600 peer-focus:dark:text-blue-500 peer-placeholder-shown:scale-100 peer-placeholder-shown:translate-y-0 peer-focus:scale-75 peer-focus:-translate-y-6"
                  >Message</label
                >
              </div>
            </div>
            <button
              @click.prevent="createData"
              type="submit"
              class="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800"
            >
              Submit
            </button>
          </form>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { NuxtLink } from "#components";
import { onMounted } from "vue";
import { toast } from "vue3-toastify";
import "vue3-toastify/dist/index.css";
import { useRoute } from "vue-router";

//const route = useRoute();
//const projectId = route.params.id;

const projectId = ref("");

const runtimeConfig = useRuntimeConfig();
const baseUrl = runtimeConfig.public.baseURL;
console.log(baseUrl);

const state = reactive({
  list: [],
  gallery: [],
  projects: [],
  data: null,
  timer: {
    days: "00",
    hours: "00",
    minutes: "00",
    seconds: "00",
  },
  offerActive: true,
});

onMounted(async () => {
  projectId.value = document.getElementById("projectId")?.value || "";
  const { Fancybox } = await import("@fancyapps/ui");
  await import("@fancyapps/ui/dist/fancybox/fancybox.css");

  Fancybox.bind("[data-fancybox]", {});

  startOfferTimer();
});

nextTick(async () => {
  getProject();
  getFeatures();
  getGallery();
  getProjects();
});

var startOfferTimer = () => {
  if (!state.data || !state.data.offerDateTime) {
    state.offerActive = false;
    return;
  }

  const offerDateTime = new Date(state.data.offerDateTime).getTime();

  const updateTimer = () => {
    const now = new Date().getTime();
    const timeLeft = offerDateTime - now;
    console.log(offerDateTime);
    if (timeLeft <= 0) {
      state.timer.days = "00";
      state.timer.hours = "00";
      state.timer.minutes = "00";
      state.offerActive = false;
      return;
    }

    const days = Math.floor(timeLeft / (1000 * 60 * 60 * 24));
    const hours = Math.floor(
      (timeLeft % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60)
    );
    const minutes = Math.floor((timeLeft % (1000 * 60 * 60)) / (1000 * 60));
    const seconds = Math.floor((timeLeft % (1000 * 60)) / 1000);

    state.timer.days = String(days).padStart(2, "0");
    state.timer.hours = String(hours).padStart(2, "0");
    state.timer.minutes = String(minutes).padStart(2, "0");
    state.timer.seconds = String(seconds).padStart(2, "0");
  };
  state.offerActive = true;
  updateTimer();
  setInterval(updateTimer, 1000);
};

var getProject = async () => {
  // var projectId = document.getElementById("projectId").value;
  //const projectId = route.params.id;
  var projectId = document.getElementById("projectId").value;
  if (!projectId) return;
  console.log(projectId);
  const { data } = await useUserAPI(
    `/api/website/getsingleproject?projectId=${projectId}`,
    {
      method: "GET",
    }
  );
  state.data = data.value;
  console.log(state.data);

  startOfferTimer();
};

var getFeatures = async () => {
  var projectId = document.getElementById("projectId").value;
  //const projectId = route.params.id;
  const { data } = await useUserAPI(
    `/api/website/getprojectfeatures?projectId=${projectId}`,
    {
      method: "GET",
    }
  );
  state.list = data.value;
};

var getGallery = async () => {
  var projectId = document.getElementById("projectId").value;
  //const projectId = route.params.id;
  const { data } = await useUserAPI(
    `/api/website/getgalleries?projectId=${projectId}`,
    {
      method: "GET",
    }
  );
  state.gallery = data.value;
};

var getProjects = async () => {
  var { data } = await useUserAPI("/api/website/getprojects", {
    method: "GET",
  });
  state.projects = data.value;
};

const createData = async () => {
  var name = document.getElementById("name").value;
  var email = document.getElementById("email").value;
  var phone = document.getElementById("phone").value;
  var subject = document.getElementById("subject").value;
  var message = document.getElementById("message").value;

  const obj2 = {
    name: name,
    email: email,
    phone: phone,
    subject: subject,
    message: message,
  };
  const { data } = await useUserAPI("/api/website/createcontactus", {
    method: "POST",
    headers: {
      "Content-Type": "application/json; charset=UTF-8",
    },
    body: JSON.stringify(obj2),
  });
  showToatSuccess(data.value);
};

const showToatSuccess = (message) => {
  toast.success(message, {
    position: "top-right",
    duration: 5000, // Toast duration in milliseconds
    dismissible: true, // Allow users to manually dismiss the toast
  });
};
</script>

<style scoped>
.headering {
  background: url(/assets/images/banner/banner-3.png) no-repeat center center;
  background-size: cover;
}
.containerw {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(350px, 1fr));
  justify-items: center;
  grid-gap: 0;
}
.item {
  width: 100%;
  overflow: hidden;
  background: #000;
}
.item a img {
  opacity: 0.6;
  width: 100%;
  height: 100%;
  transform: scale(1.15);
  transition: transform 0.5s, opacity 0.5s;
}
.item a img:hover {
  opacity: 1;
  transform: scale(1.03);
}
p {
  font-family: "Playfair Display", serif !important;
  font-optical-sizing: auto !important;
  font-weight: 400 !important;
  font-style: normal !important;
}
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

.marquee {
  height: auto;
  line-height: 4.5;
  max-width: 100%;
  overflow: hidden;
  position: relative;
  width: 100vw;
}

.marquee .track {
  animation: marquee 100s linear infinite;
}

.marquee .text-track,
.marquee .track {
  white-space: nowrap;
  will-change: transform;
}

.marquee .text-track {
  animation: marquee 20s linear infinite;
}

.marquee .track-2 {
  animation: marquee-left 100s linear infinite;
  white-space: nowrap;
  will-change: transform;
}

@keyframes marquee {
  0% {
    transform: translateX(0);
  }

  to {
    transform: translateX(-50%);
  }
}

@keyframes marquee-left {
  to {
    transform: translateX(0);
  }

  0% {
    transform: translateX(-50%);
  }
}

.marquee:hover .text-track {
  animation-play-state: paused;
}
</style>
