<template>
    <v-menu ref="menu"
            v-model="menu"
            :close-on-content-click="false"
            transition="scale-transition"
            offset-y
            max-width="290px"
            min-width="290px">
        <template v-slot:activator="{ on }">
            <v-text-field v-model="dateFormatted"
                          dense
                          persistent-hint
                          readonly
                          :outlined="outlined"
                          @blur="result = parseDate(dateFormatted)"
                          v-on="on"
                          :disabled="!isEdit"></v-text-field>
        </template>
        <v-date-picker v-model="result" no-title @input="menu = false" locale="ru-RU"
                       first-day-of-week=1></v-date-picker>
    </v-menu>
</template>

<script>export default {
        name: 'DatePicker',

        props: {
            outlined: {
                type: Boolean,
                required: true
            },
            isEdit: {
                type: Boolean,
                required: true
            },
            date: {
                type: String,
                default: ''
            },
        },

        data: () => ({
            dateFormatted: null,
            menu: false,
            result: null,
        }),

        methods: {
            formatDate(date) {
                if (!date) return null

                const [year, month, day] = date.split('-')
                return `${day}.${month}.${year}`
            },
            parseDate(date) {
                if (!date) return null

                const [day, month, year] = date.split('.')
                return `${year}-${month.padStart(2, '0')}-${day.padStart(2, '0')}`
            },
        },

        computed: {
            computedDateFormatted() {
                return this.formatDate(this.result)
            }
        },

        watch: {
            result(val) {
                this.dateFormatted = this.formatDate(this.result)
                this.$emit('dateChanged', this.result)
            },
        },

        created() {
            if (this.date) {
                this.result = this.date.slice(0, 10)
            }
        },
    };</script>

