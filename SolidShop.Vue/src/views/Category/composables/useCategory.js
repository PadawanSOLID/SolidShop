import { ref ,onMounted} from "vue"
import { getCategoryAPI } from "@/apis/category"
import { useRoute, onBeforeRouteUpdate } from 'vue-router';
export function useCategory() {
    const categoryData = ref({})
    const route = useRoute()
    onBeforeRouteUpdate(to => {
        getCategory(to.params.id)
    })
    const getCategory = async (id = route.params.id) => {
        const res = await getCategoryAPI(id)
        console.log(res)
        categoryData.value = res
    }
    onMounted(() => getCategory())
    return {
        categoryData
    }
}
