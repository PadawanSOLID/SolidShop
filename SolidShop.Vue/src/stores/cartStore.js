
import { defineStore } from "pinia";
import { computed, ref } from "vue";
import { useUserStore } from "./user";
export const useCartStore = defineStore('cart', () => {
    const userStore=useCartStore()
    const isLogin=computed(()=>userStore.userInfo.token)
    const cartList = ref([])

    const addCart = (goods) => {
        const item = cartList.value.find((item) => goods.id == item.id)
        if (item) {
            console.log(item.count, goods.count)
            item.count += goods.count
        }

        else {
            cartList.value.push(goods)
        }
    }
    const delCart = (id) => {
        const idx = cartList.value.findIndex(item => id === item.id)
        cartList.value.splice(idx, 1)
    }
    const singleCheck = (id, selected) => {
        const item = cartList.value.find(item => item.id === id)
        item.selected = selected
    }
    const allCheck = (selected) => {
        cartList.value.forEach(n => n.selected = selected)
    }
    const allCount = computed(() => cartList.value.reduce((a, c) => a + c.count, 0))
    const allPrice = computed(() => cartList.value.reduce((a, c) => a + c.count * c.price, 0))
    const isAll = computed(() => cartList.value.every(item => item.selected))
    const selectedCount = computed(() => cartList.value.filter(n => n.selected).reduce((a, c) => a + c.count, 0))
    const selectedPrice = computed(() => cartList.value.filter(n => n.selected).reduce((a, c) => a + c.count * c.price, 0))
    return {
        cartList,
        allCount,
        allPrice,
        isAll,
        addCart,
        delCart,
        singleCheck,
        allCheck,
        selectedCount,
        selectedPrice,
        isLogin,
    }
},
    {
        persist: true
    }
)