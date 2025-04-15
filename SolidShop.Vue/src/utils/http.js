import { useUserStore } from "@/stores/user";
import axios from "axios";
import { ElMessage } from "element-plus";
import { useRouter } from "vue-router";


const httpInstance = axios.create({
    baseURL: 'http://localhost:5200/api',
    timeout: 5000
})

httpInstance.interceptors.request.use(config => {
    const userStore=useUserStore()
    const token=userStore.userInfo.token
    if(token){
        config.headers.Authorization=`Bearer ${token}`
    }
    return config
}, e => Promise.reject(e))

httpInstance.interceptors.response.use(res => res.data, e => {
    ElMessage({
        type: 'warning',
        message: e.response
    })
    if(e.response.status===401){
        const userStore=useUserStore()
        userStore.clearUserInfo()
        const router=useRouter()
        router.push('/login')
    }

    Promise.reject(e)
})
export default httpInstance