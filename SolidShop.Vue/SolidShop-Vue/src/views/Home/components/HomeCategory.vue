<template>
    <div class="home-category">
        <ul class="menu">
            <li v-for="item in categoryStore.categoryList" :key="item.id">
                <RouterLink to="/">{{ item.name }}</RouterLink>
                <RouterLink v-for="i in 2" :key="i" to="/">南北干货</RouterLink>
                <div class="layer">
                    <h4>分类推荐<small>根据您的购买或浏览记录推荐</small></h4>
                    <ul>
                        <li v-for="i in 5" :key="i">
                            <RouterLink to="/">
                                <img alt="">
                                <div class="info">
                                    <p class="name ellipsis-2">男士外套</p>
                                    <p class="desc ellipsis">男士外套，冬季必选</p>
                                    <p class="price"><i>￥</i>200.00</p>
                                </div>
                            </RouterLink>
                        </li>
                    </ul>
                </div>
            </li>
        </ul>
    </div>
</template>

<script setup>
import { useCategoryStore } from '@/stores/category'
const categoryStore = useCategoryStore();
</script>

<style lang="scss" scoped>
.home-category {
    margin: 0 auto;
    width: 1200px;
    height: 500px;

    position: relative;
    z-index: 99;

    .menu {
        padding-inline-start: 0;

        li {
            list-style: none;
            height: 55px;
            width: 250px;
            padding-left: 30px;
            line-height: 55px;
            display: flex;
            background-color: rgba(0, 0, 0, 0.8);

            &:hover {
                background-color: #009927;
            }

            &:hover>.layer {
                display: block;
            }

            a {
                padding: 0 6px;
                color: #e6e6e6;
                text-decoration: none;
            }
        }

        .layer {
            background-color: white;
            position: absolute;
            display: none;
            left: 280px;
            width: 950px;
            top: 0;

            ul {
                position: relative;
                flex-wrap: wrap;
                display: flex;

                li {
                    height: 120px;
                    border: 1px solid #ddd;
                    border-radius: 3px;
                    margin: 5px;
                    padding: 5px 20px;
                }

                a {
                    display: flex;
                    align-items: center;

                    img {
                        margin: 0 10px;
                        height: 100px;
                        width: 100px;
                    }

                    .info {
                        p {
                            line-height: 16px;
                            font-size: 16px;
                        }
                    }
                }
            }
        }

    }

}
</style>