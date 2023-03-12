# MODEL

> Tetofo uses hybrid model abstraction. It differes from common [MVC](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93controller) usage of model by adding more [DOF](https://en.wikipedia.org/wiki/Degrees_of_freedom) into the scheme. With this approach data could be abstracted into model model class. Preffered approach is that model is used to describe data such a where it is possile to obtain data, what is data structure and how to wotk with data.

### Resources

-

# Stage 1

## IData

> Basic abstraction is provided via IData.
> - Tags - describes what is represented by this object
> - Payload - representes content. JSON format is prefered.
> - Members - to satisfy [composite pattern](https://en.wikipedia.org/wiki/Composite_pattern).
