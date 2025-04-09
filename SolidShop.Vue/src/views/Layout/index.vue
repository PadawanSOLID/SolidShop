<template>
     <LayoutNav />
    <LayoutHeader />
    <LayoutFixed />
   
    <RouterView />
    <LayoutFooter />
</template>

<script setup>
import LayoutHeader from './components/LayoutHeader.vue'
import LayoutNav from './components/LayoutNav.vue'
import LayoutFooter from './components/LayoutFooter.vue'
import LayoutFixed from './components/LayoutFixed.vue'
import { useCategoryStore } from '@/stores/useCounterStore'
import { onMounted } from 'vue'
const categoryStore = useCategoryStore()
onMounted(() => categoryStore.getCategory())
</script>

<style lang="scss" scoped></style>