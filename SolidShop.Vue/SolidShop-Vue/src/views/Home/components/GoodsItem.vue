<template>
    <RouterLink to="/" class="goods-item">
        <img v-img-lazy="goods.picture" alt="">
        <p class="name ellipsis">{{ goods.name }}</p>
        <p class="desc ellipsis">{{ goods.desc }}</p>
        <p class="price ellipsis">{{ goods.price }}</p>
    </RouterLink>
</template>

<script setup>
defineProps({
    goods: {
        type: Object,
        default: () => { }
    }
})
</script>

<style lang="scss" scoped>
.goods-item {
    display: block;
    width: 200px;
    padding: 20px 30px;
    text-align: center;
    transition: all .5s;

    &:hover {
        transform: translate3d(0, -3px, 0);
        box-shadow: 0 3px 8px rgb(0 0 0 / 20%);
    }

    img {
        height: 160px;
        width: 160px;
    }

    p {
        padding-top: 10px;
    }

    .name {
        font-size: 16px;
    }

    .desc {
        color: #999;
    }

    .price {
        color: #ff6700;
        font-size: 20px;
    }
}
</style>