import { getCategoryAPI } from "@/apis/layout";
import { onMounted } from "vue";
import  { onBeforeRouteUpdate,useRoute } from "vue-router";
import { ref } from "vue";
export default function useCategory() {
    const categoryData = ref({})
    const route = useRoute()
    const getCategory = async (id = route.params.id) => {
        const res = await getCategoryAPI(id)
        categoryData.value = res
    }
    onMounted(() => getCategory())
    onBeforeRouteUpdate((to) => {
        getCategory(to.params.id)
    })
    return {categoryData}
}
