<template>
    <div class="goods-image">
        <div class="middle" ref="target">
            <img :src="imageList[0]" alt="">
            <div class="layer" :style="{ left: `0px`, top: `0px` }"></div>
        </div>
        <ul class="small">
            <li v-for="(img, i) in imageList" :key="i">
                <img :src="img" alt="">
            </li>
        </ul>
        <div class="large" :style="[{
            backgroundImage: `url(${imageList[0]})`,
            backgroundPositionX:`0px`,
            backgroundPositionY:`0px`,
        }]" v-show="false"></div>
    </div>
</template>

<script setup>
const imageList = []
</script>

<style lang="scss" scoped>
.goods-image{
    width: 480px;
    height: 400px;
    position: relative;
    display: flex;
    .middle{
        width: 400px;
        height: 400px;
        background: #f5f5f5;
    }
}
.layer {
    width: 200px;
    height: 200px;
    background: rgba(0, 0, 0, 0.2);
    left: 0;
    top: 0;
    position: absolute;
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