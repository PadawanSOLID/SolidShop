<template>
    <div class="home-product">
        <HomePanel :title="cate.name" v-for="cate in goodsProduct" :key="cate.id">
            <div class="box">
                <RouterLink class="cover" to="/">
                    <img :src="cate.image" alt="">
                    <strong class="label">
                        <span>{{ cate.name }}</span>
                        <span>{{ cate.saleInfo }}</span>
                    </strong>
                </RouterLink>
                <ul class="goods-list">
                    <GoodsItem v-for="good in cate.goods" :key="good.id" :good></GoodsItem>
                </ul>
            </div>
        </HomePanel>
    </div>
</template>

<script setup>
import HomePanel from './HomePanel.vue'
import GoodsItem from './GoodsItem.vue'
import getGoodsAPI from '@/apis/home'
import { ref, onMounted } from 'vue'
const goodsProduct = ref([])

const getGoods = async () => {
    const res = await getGoodsAPI()
    goodsProduct.value = res
}


onMounted(() => {
    getGoods()
})

</script>

<style lang="scss" scoped>
.home-product {
    background-color: white;
    margin-top: 20px;

    .sub {
        margin-bottom: 2px;

        a {
            padding: 2px 12px;
            font-size: 16px;
            border-radius: 4px;

            &:hover {
                background-color: #ff6700;
                color: white;
            }

            &:last-child {
                margin-right: 80px;
            }
        }
    }

    .box {
        display: flex;

        .cover {
            width: 240px;
            height: 610px;
            margin-right: 10px;
            position: relative;
        }

        img {
            height: 100%;
            width: 100%;
        }

        .label {
            width: 188px;
            height: 66px;
            display: flex;
            font-size: 18px;
            color: white;
            line-height: 66px;
            font-weight: normal;
            position: absolute;
            left: 0;
            top: 50%;
            transform: translate3d(0, -50%, 0);

            span {
                text-align: center;

                &:first-child {
                    width: 76px;
                    background: rgba(0, 0, 0, 0.9);
                }

                &:last-child {
                    flex: 1;
                    background: rgba(0, 0, 0, 0.7);
                }
            }
        }
    }
}
</style>