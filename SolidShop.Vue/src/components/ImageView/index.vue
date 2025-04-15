<template>
    <div class="goods-image">
        <div class="middle" ref="target">
            <img :src="imageList[activeIndex]" alt="">
            <div class="layer" v-show="!isOutside" :style="{ left: `${left}px`, top: `${top}px` }"></div>
        </div>
        <ul class="small">
            <li v-for="(img, i) in imageList" :class="{ active: i === activeIndex }" :key="i"
                @mouseenter="enterHandler(i)">
                <img :src="img" alt="">
            </li>
        </ul>
        <div class="large" :style="[{
            backgroundImage: `url(${imageList[activeIndex]})`,
            backgroundPositionX: `${posX}px`,
            backgroundPositionY: `${posY}px`,
        }]" v-show="!isOutside"></div>
    </div>
</template>

<script setup>
import { useMouseInElement } from '@vueuse/core';
import { ref, watch } from 'vue';
defineProps({
    imageList:{
        type:Array,
        default:()=>[]
    }
})
const target = ref(null)
const { elementX, elementY, isOutside } = useMouseInElement(target)
const activeIndex = ref(0)
const enterHandler = (i) => {
    activeIndex.value = i
}
const left = ref(0)
const top = ref(0)
const posX = ref(0)
const posY = ref(0)
watch([elementX, elementY, isOutside], () => {
    if (isOutside.value) return

    if (elementX.value > 100 && elementX.value < 300)
        left.value = elementX.value - 100
    if (elementY.value > 100 && elementY.value < 300)
        top.value = elementY.value - 100
    if (elementX.value > 300) left.value = 200
    if (elementY.value > 300) top.value = 200
    if (elementX.value < 100) left.value = 0
    if (elementY.value < 100) top.value = 0
    posX.value = -left.value * 2
    posY.value = -top.value * 2
})
</script>

<style lang="scss" scoped>
.goods-image {
    width: 480px;
    height: 400px;
    position: relative;
    display: flex;

    .middle {
        width: 400px;
        height: 400px;
        background: #f5f5f5;
    }
}

.large {
    position: absolute;
    top: 0;
    left: 412px;
    width: 400px;
    height: 400px;
    z-index: 500;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    background-repeat: no-repeat;
    background-size: 800px 800px;
    background-color: #f8f8f8;
}

.layer {
    width: 200px;
    height: 200px;
    background: rgba(0, 0, 0, 0.2);
    left: 0;
    top: 0;
    position: absolute;
}

img {
    height: 100%;
    width: 100%;
}

.small {
    width: 80px;

    li {
        width: 68px;
        height: 68px;
        margin-left: 12px;
        margin-bottom: 15px;
        cursor: pointer;

        &:hover,
        &.active {
            border: 2px solid $xtxColor;
        }

    }
}
</style>