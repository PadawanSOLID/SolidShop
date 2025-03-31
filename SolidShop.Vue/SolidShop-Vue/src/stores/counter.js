import { defineStore } from "pinia";
import { computed, ref } from "vue";
export const useCounterStore = defineStore('counter', () => {
    //data
    const count = ref(0)

    //action
    const increment = (num) => {
        count.value+= num;
    }

    const doubleCount=computed(()=>count.value*2)

    return {
        count,
        increment
    }
})