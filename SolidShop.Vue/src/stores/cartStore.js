
import { defineStore } from "pinia";
import { ref } from "vue";

export const useCartStore = defineStore('cart', () => {
    const cartList = ref([])
    const addCart = (goods) => {
        const item = cartList.value.find((item) => goods.id == item.id)
        if (item){
            console.log(item.count,goods.count)
            item.count+=goods.count
        }
           
        else{
            cartList.value.push(goods)
        }
    }
    const delCart=(id)=>{
        const idx=cartList.value.findIndex(item=>id===item.id)
        cartList.value.splice(idx,1)
    }
    return {
        cartList,
        addCart,
    }},
    {
        persist:true
    }
)