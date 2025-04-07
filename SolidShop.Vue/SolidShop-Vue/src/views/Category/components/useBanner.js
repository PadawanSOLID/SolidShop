import getBannerAPI from "@/apis/home";
import httpInstance from "@/utils/http";
import { ref, onMounted } from "vue";

export default function useBanner() {
    const bannerList = ref([])
    const getBanner = async () => {
        const res = await getBannerAPI({ distributionSite: '2' })
        console.log(res)
        bannerList.value = res
    }

    onMounted(() => getBanner())
    return { bannerList }
}

export function getCategoryFilterAPI(id) {
    return httpInstance({
        url: '/category/sub/filter',
        params: {
            id
        }
    })
}