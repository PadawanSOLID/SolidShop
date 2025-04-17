import { loginAPI } from "@/apis/user";
import { ref } from "vue";
import { defineStore } from "pinia";
import { useCartStore } from "./cartStore";
export const useUserStore = defineStore(
    'user', 
    () => {
    const userInfo = ref({})
    const getUserInfo = async ({ account, password }) => {
        const res = await loginAPI({ account, password })
        userInfo.value=res
    }
    const clearUserInfo=()=>{
        userInfo.value={}
    }
    return {
        userInfo,
        getUserInfo,
        clearUserInfo
    }
},
    {
        persist: true
    }
)