<template>
    <div class="home-banner">
        <el-carousel height="500px">
            <el-carousel-item v-for="item in bannerList" :key="item">
                <img :src="item">
            </el-carousel-item>
        </el-carousel>
    </div>
</template>

<script setup>
import getBannerAPI from '@/apis/home'
import { ref, onMounted } from 'vue'
const bannerList = ref([])

const getBanner = async () => {
    const res = await getBannerAPI();
    bannerList.value = res.map(n => "/src/assets/images/" + n)
    console.log(bannerList.value)
}

onMounted(() => {
    getBanner()
})

</script>

<style lang="scss" scoped>
.home-banner {
    width: 1240px;
    height: 500px;
    position: absolute;
    left: 0;
    top: 0;
    z-index: 98;

    img {
        width: 100%;
        height: 500px;
    }
}
</style>