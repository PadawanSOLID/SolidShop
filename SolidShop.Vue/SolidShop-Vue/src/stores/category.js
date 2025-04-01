import { getCategoryAPI } from "@/apis/layout";
import { defineStore } from "pinia";
import { ref } from "vue";

export const useCategoryStore = defineStore('category', () => {
    const categoryList = ref([])
    const getCategory = async () => {
        const res = await getCategoryAPI()
        console.log(res)
        categoryList.value = res
    }
    return {
        categoryList,
        getCategory
    }
})