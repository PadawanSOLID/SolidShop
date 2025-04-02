<template>
    <div class="home-panel">
        <div class="container">
            <div class="head">
                <h3>
                    {{ title }}<small>{{ subtitle }}</small>
                </h3>
            </div>
            <div>
                <slot/>
            </div>
        </div>

    </div>
</template>

<script setup>

defineProps({
    title: {
        type: String
    },
    subtitle: {
        type: String
    }
})
</script>

<style lang="scss" scoped>
.home-panel {
    background-color: white;

    .head {
        padding: 40px 0;
        display: flex;
        align-items: flex-end;

        h3 {
            flex: 1;
            font-size: 32px;
            font-weight: normal;
            margin-left: 6px;
            height: 35px;
            line-height: 35px;

            small {
                font-size: 16px;
                color: #999;
                margin-left: 20px;
            }
        }
    }
}
</style>