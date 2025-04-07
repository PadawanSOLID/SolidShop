<template>
    <header class="app-header">
        <div class="container">
            <h1 class="logo">
                <RouterLink  to="/">小兔鲜</RouterLink>
            </h1>
            <ul class="app-header-nav">
                <li v-for="item in categoryStore.categoryList" :key="item.id">
                    <RouterLink active-class="active" :to='`/category/${item.id}`'>{{ item.name }}</RouterLink>
                </li>
            </ul>
            <div class="search">
                <i class="iconfont icon-search"></i>
                <input type="text" placeholder="搜一搜">
            </div>
        </div>
    </header>
</template>

<script setup>
import { useCategoryStore } from '@/stores/category.js'
const categoryStore = useCategoryStore()
</script>

<style lang="scss" scoped>
.container {
    display: flex;
    align-items: center;
    justify-content: space-between;
}

.logo {
    color: #333;

    a {
        text-decoration: none;
        color: #009927;
    }
}

.app-header-nav {
    display: flex;
    color: #000;

    a {
        text-decoration: none;
        color: #000;
    }
    .active{
    color: aqua;
    text-decoration: underline;
}
    li {
        padding: 20px 10px;
        list-style: none;
    }
}

.search {
    align-self: center;
    width: 170px;
    height: 32px;
    position: relative;
    border-bottom: 1px solid #e7e7e7;
    line-height: 32px;
    display: flex;

    .icon-search {
        font-size: 18px;
        margin-left: 5px;
    }

    input {
        width: 140px;
    }

}

.cart {
    width: 50px;

    .curr {
        height: 32px;
        line-height: 32px;
        text-align: center;
        position: relative;
        display: block;

        .icon-cart {
            font-size: 22px;
        }

        em {
            font-style: normal;
            position: absolute;
            right: 0;
            top: 0;
            padding: 1px 6px;
            line-height: 1;
            background-color: #666;
            color: #fff;
            font-size: 12px;
            border-radius: 10px;
        }

    }
}


</style>