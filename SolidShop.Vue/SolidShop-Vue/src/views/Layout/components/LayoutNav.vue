<template>
    <nav class="app-topnav">
        <div class="container">
            <ul class="ul">
                <template v-if="true">
                    <li><a href="#"><i class="iconfont icon-user"></i>周杰伦</a></li>
                    <li>
                        <a href="#">退出登录</a>
                    </li>
                    <li><a href="#">我的订单</a></li>
                    <li><a href="#">会员中心</a></li>
                </template>
                <template v-else>
                    <li><a href="#">请先登录</a></li>
                    <li><a href="#">帮助中心</a></li>
                    <li><a href="#">关于我们</a></li>
                </template>
            </ul>
        </div>
    </nav>
</template>

<script setup>

</script>

<style lang="scss" scoped>
.app-topnav {
    background-color: #333;

    ul {
        display: flex;
        height: 53px;
        justify-content: flex-end;
        align-items: center;

        li {
            list-style: none;

            a {
                padding: 0 15px;
                color: #cdcdcd;
                line-height: 1;
                display: inline-block;
                text-decoration: none;

                i {
                    font-size: 14px;
                    margin-right: 2px;
                }

                &:hover {
                    color: #ff6700
                }
            }
        }

        ~li {
            a {
                border-left: 2px solid #666;
            }
        }
    }
}
</style>