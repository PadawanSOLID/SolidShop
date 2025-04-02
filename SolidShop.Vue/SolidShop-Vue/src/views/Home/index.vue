<template>
    <div class="category">
        <HomeCategory />
        <HomeBanner />       
    </div>
    <HomeNew />
    <HomeHot />
    <HomeProduct />

 

    <div style="height: 1200px;"></div>
</template>

<script setup>
import HomeCategory from './components/HomeCategory.vue'
import HomeBanner from './components/HomeBanner.vue'
import HomeHot from './components/HomeHot.vue'
import HomeNew from './components/HomeNew.vue'
import HomeProduct from './components/HomeProduct.vue'
</script>

<style lang="scss" scoped>
.category {
    position: relative;
    width: 1200px;
    margin: 0 auto;
}
</style>