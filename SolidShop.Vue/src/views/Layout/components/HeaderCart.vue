<template>
    <div class="cart">
        <a href="/cartList" class="curr">
            <i class="iconfont icon-cart"><em>2</em></i>
        </a>
        <div class="layer">
            <div class="list">
                <div class="item" v-for="i in cartStore.cartList" :key="i.id">
                    <RouterLink to="/">
                        <img :src="i.picture" alt="">
                        <div class="center">
                            <p class="name">
                                {{ i.name }}
                            </p>
                            <p class="attr">
                                {{ i.attrsText }}
                            </p>
                        </div>
                        <div class="right">
                            <p class="price">&yen;{{ i.price }}</p>
                            <p class="count">x{{ i.count }}</p>
                        </div>

                    </RouterLink>
                    <i class="iconfont icon-close" @click="cartStore.delCart(i.id)"></i>
                </div>
                <div class="foot">
                    <div class="total">
                        <p>共 {{cartStore.allCount}} 件商品</p>
                        <p>&yen; {{cartStore.allPrice}}</p>
                    </div>
                    <el-button size="larget" type="primary">去购物车结算</el-button>
                </div>
            </div>
        </div>
    </div>
</template>

<script setup>
import { useCartStore } from '@/stores/cartStore';
import { computed } from 'vue';
const cartStore = useCartStore()

</script>

<style lang="scss" scoped>
.cart {
    width: 50px;
    z-index: 600;
    position: relative;

    &:hover {
        .layer {
            opacity: 1;
            transform: none;
        }
    }

    .curr {
        display: block;
        width: 32px;
        height: 32px;
        line-height: 32;
        text-align: center;

        .icon-cart {
            position: absolute;
            right: 0;
            display: inline-block;
            top: -330px;
            font-size: 22px;
        }

        em {
            font-style: normal;
            right: 0;
            top: 0;
            padding: 1px 6px;
            line-height: 1;
            background: $helpColor;
            color: #fff;
            font-size: 12px;
            border-radius: 10px;
            font-family: Arial;
        }


    }

    .layer {
        opacity: 0;
        transition: ALL 0.4S 0.2S;
        transform: translateY(-200PX) scale(1, 0);
        position: absolute;
        height: 400px;
        width: 400px;
        background: #fff;

        .list {
            height: 310px;
            overflow: auto;
            padding: 0 10px;

            &::-webkit-scrollbar {
                width: 10px;
                height: 10px;
            }

            &::-webkit-scrollbar-track {
                background: #f8f8f8;
                border-radius: 2px;
            }

            &::-webkit-scrollbar-thumb {
                background: #eee;
                border-radius: 10px;
            }

            &::-webkit-scrollbar-thumb:hover {
                background: #ccc;
            }

            .item {
                border-bottom: 1px solid #f5f5f5;
                padding: 10px 0;
                position: relative;

                a {
                    display: flex;
                    align-items: center;

                    img {
                        height: 80w 80px;
                    }

                    .center {
                        padding: 0 10px;
                        width: 200px;

                        .name {
                            font-size: 16px;
                        }

                        .attr {
                            color: #999;
                            padding-top: 5px;
                        }
                    }

                    .right {
                        width: 100px;
                        padding-right: 20px;
                        text-align: center;

                        .price {
                            font-size: 16px;
                            color: $priceColor;
                        }

                        .count {
                            color: #999;
                            margin-top: 5px;
                            font-size: 16px;
                        }
                    }
                }

                &:hover {
                    i {
                        opacity: 1;
                        cursor: pointer;
                    }
                }
            }
        }
    }

}

.total {
    padding-left: 10px;
    color: #999;

    p {
        &:last-child {
            font-size: 18px;
            color: $priceColor;
        }
    }
}



.foot {
    position: absolute;
    left: 0;
    bottom: 0;
    height: 70px;
    width: 100%;

    i {
        position: absolute;
        bottom: 38px;
        right: 0;
        opacity: 0;
        color: #666;
        transform: all 0.5s;
    }


}
</style>