<template>
    <div class="app-header-sticky" :class="{ show: y > 78 }">
        <div class="container">
            <RouterLink class="logo" to="/" />
            <ul class="app-header-nav">
                <li class="home" v-for="item in categoryStore.categoryList" :key="item.id">
                    <RouterLink to="/">{{ item.name }}</RouterLink>
                </li>
            </ul>
            <div class="right">
                <RouterLink to="/">品牌</RouterLink>
                <RouterLink to="/">专题</RouterLink>
            </div>
        </div>
    </div>
</template>

<script setup>
import { useScroll } from '@vueuse/core'
import { useCategoryStore } from '@/stores/category.js'
const categoryStore = useCategoryStore()


const { y } = useScroll(window)
</script>

<style lang="scss" scoped>
.app-header-sticky {
    width: 100%;
    height: 80px;
    position: fixed;
    left: 0;
    top: 0;
    z-index: 999;
    background-color: white;
    border-bottom: 1px solid #e4e4e4;
    transform: translateY(-100%);
    opacity: 0;

    &.show {
        transition: all 0.3 linear;
        transform: none;
        opacity: 1;
    }

    .container {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

    .app-header-nav {
        display: flex;

        li {
            list-style: none;
            padding: 0 10px;
        }

    }

    a {
        color: black;
        text-decoration: none;
    }
}
</style>